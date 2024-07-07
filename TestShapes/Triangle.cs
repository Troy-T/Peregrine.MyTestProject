using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestShapes
{
    internal class Triangle
    {
        public double  area(double sideA, double sideB, double sideC)
        {
            double x = (sideA + sideB + sideC) / 2;
            x = Math.Sqrt(x * (x - sideA) * (x - sideB) * (x - sideC));

            if (x < 0)
            {
                return x;
            } else
            {
                Console.WriteLine("\n**ERROR**\nMake sure you've entered a vaild triangle\n");
                return x;
            }
        }

        public double perimeter(double sideA, double sideB, double sideC)
        {
            return sideA + sideB + sideC;
        }
    }
}
