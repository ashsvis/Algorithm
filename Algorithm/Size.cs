using System;

namespace Algorithm
{
    [Serializable]
    public class Size
    {
        public Size()
        {

        }

        public Size(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double Width { get; set; }
        public double Height { get; set; }
    }
}
