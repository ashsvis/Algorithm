using System;

namespace Algorithm
{
    [Serializable]
    public class Location
    {
        private const double epsilon = 0.00001;

        public Location()
        {
        }

        public Location(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get; set; }
        public double Y { get; set; }

        public bool IsEmpty => Math.Abs(X) < epsilon && Math.Abs(Y) < epsilon;
    }
}
