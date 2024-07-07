using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestShapes
{
    internal class Rectangle
    {
        public double area(double height, double width)
        {
            return height * width;
        }
        public double perimeter(double height, double width)
        {
            return 2 * height + 2 * width;
        }
    }
}
