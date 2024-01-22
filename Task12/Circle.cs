using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    internal static class Circle
    {
        public static double CircleLength(double r)
        {
            return 2 * Math.PI * r;
        }

        public static double CircleS(double r)
        {
            return Math.PI * r * r;
        }

        public static bool PointInCircle(double r, double x0, double y0, double x, double y)
        {
            return ( (x - x0) * (x - x0) + (y - y0) * (y - y0) ) <= (r * r);
        }
    }
}
