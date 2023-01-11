using Algorithm;
using System;
using System.Drawing.Drawing2D;
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
        }

        private bool contentChanged = false;
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
            if (e.Button == MouseButtons.Left)
            {
                buttonPressed = e.Button == MouseButtons.Left;
                // ищем вершину с координатами рядом с точкой нажатия
                var figure = figures.Find(fig => GraphicsHelper.Contains(fig, e.Location));
                if (figure == null) 
                {
                    figure = new Figure() { Location = new Location(e.Location.X, e.Location.Y) };
                    figures.Add(figure);
                    Invalidate();
                }
            }
        }

        /// <summary>
        /// Метод обработки перемещения курсора мыши на поверхности компонента
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (buttonPressed)
            {

            }
        }

        /// <summary>
        /// Метод обработки отпускания кнопи мыши
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseUp(MouseEventArgs e)
        {
            buttonPressed = false;
        }
    }
}
