using Algorithm;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace AlgorithmViewer
{
    public partial class AlgorithmUC : UserControl
    {
        private bool buttonPressed = false;

        private Figures figures = new Figures();

        public AlgorithmUC()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint | ControlStyles.ResizeRedraw, true);
            figureContextMenu.Opening += FigureContextMenu_Opening;
            tsmiAddFigure.Click += TsmiAddFigure_Click;
            tsmiRemoveFigure.Click += TsmiRemoveFigure_Click;
        }

        private Point lastMouseLocation = Point.Empty;
        private Figure figure;
        private bool contentChanged = false;
        private int lastVertexIndex;
        private Algorithm.Size shiftSize = new Algorithm.Size(0, 0);

        public event EventHandler<EventArgs> ContentChanged;

        /// <summary>
        /// Метод прорисовки поверхности компонента
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            var gr = e.Graphics;
            gr.SmoothingMode = SmoothingMode.HighQuality;
            foreach (var fig in figures)
            {
                GraphicsHelper.DrawFigure(gr, fig);
            }
        }

        /// <summary>
        /// Метод обработки нажатия мыши на поверхности компонента
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            lastMouseLocation = e.Location;
            figure = figures.FindLast(fig => GraphicsHelper.Contains(fig, e.Location));
            if (figure != null)
            {
                lastVertexIndex = figures.FindLastIndex(v => v.Location.Equals(figure.Location));
                shiftSize.Width = figure.Location.X - e.Location.X;
                shiftSize.Height = figure.Location.Y - e.Location.Y;
            }
            else
                lastVertexIndex = -1;
            if (e.Button == MouseButtons.Left)
            {
                buttonPressed = e.Button == MouseButtons.Left;
                contentChanged = false;
            }
            else
                figureContextMenu.Show(this, e.Location);
        }

        /// <summary>
        /// Метод обработки перемещения курсора мыши на поверхности компонента
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            Cursor = figures.Any(fig => GraphicsHelper.Contains(fig, e.Location)) ? Cursors.Hand : Cursors.Default;
            if (buttonPressed)
            {
                if (lastVertexIndex >= 0 && lastVertexIndex < figures.Count)
                {
                    // перемещаем одну вершину
                    figures[lastVertexIndex].Location = new Location(e.Location.X + shiftSize.Width, e.Location.Y + shiftSize.Height);
                    contentChanged = true;
                    Invalidate();
                }
            }
        }

        /// <summary>
        /// Метод обработки отпускания кнопи мыши
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            buttonPressed = false;
        }

        private void FigureContextMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            tsmiAddFigure.Visible = figure == null;
            tsmiRemoveFigure.Visible = figure != null;
        }

        private void TsmiAddFigure_Click(object sender, EventArgs e)
        {
            var figure = new Figure() { Location = new Location(lastMouseLocation.X, lastMouseLocation.Y) };
            figures.Add(figure);
            Invalidate();
        }

        private void TsmiRemoveFigure_Click(object sender, EventArgs e)
        {
            if (figure != null)
            {
                figures.Remove(figure);
                Invalidate();
            }
        }
    }
}
