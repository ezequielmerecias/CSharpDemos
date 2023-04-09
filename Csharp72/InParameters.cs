using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp72
{
    internal class InParameters
    {
    }

    struct Point
    {
        public double X, Y;

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"({X},{Y}";
        }

        public void Reset()
        {
            X = Y = 0;
        }
    }

    class program
    {
        //In indicate is pass by value
        public double MeasureDistance(in Point p1, in Point p2)
        {
            p1.Reset();
            var dx = p1.X - p2.X;
            var dy = p1.Y - p2.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

    }


}
