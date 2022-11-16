using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework12
{
    internal static class Circle
    {
        public static double GetLength(double r)
        {
            return 2 * Math.PI * r;
        }
        public static double GetArea(double r)
        {
            return Math.PI * r * r;
        }
        public static bool IsInCircle(double r, double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2)) <= r;
        }
    }
}
