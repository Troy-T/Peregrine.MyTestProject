using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TestShapes
{
    internal class Circle
    {
        public double area(double radius)
        {
            return Math.PI * Math.Pow( radius, 2.0);
        }

        public double perimeter(double radius)
        {
            return 2 * Math.PI * radius;
        }
    }
}
