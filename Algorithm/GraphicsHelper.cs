using System;
using System.Drawing;

namespace Algorithm
{
    public static class GraphicsHelper
    {
        public static bool Contains(Figure fig, Point location)
        {
            return location.X >= fig.Location.X && location.X <= fig.Location.X + fig.Size.Width &&
                   location.Y >= fig.Location.Y && location.Y <= fig.Location.Y + fig.Size.Height;
        }

        public static void DrawFigure(Graphics graphics, Figure figure, Pen pen = null)
        {
            graphics.DrawRectangle(pen ?? Pens.Black, (float)figure.Location.X, (float)figure.Location.Y, 
                                               (float)figure.Size.Width, (float)figure.Size.Height);
        }
    }
}
