using System;

namespace Algorithm
{
    [Serializable]
    public class Location
    {
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
    }
}
