using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestShapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 0;
            double y = 0;
            double z = 0;

            Console.WriteLine("Welcome!");
            Console.WriteLine("This program takes numerals as inputs for the attributes");
            Console.WriteLine("of specific shapes and outputs their various areas and");
            Console.WriteLine("perimeters.\n\n");

            //Circle
            Circle circ = new Circle();

            Console.WriteLine("Circle Calculations:");
            Console.WriteLine("Input your circles radius: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"Area of cicrle: {circ.area(x)}");
            Console.WriteLine("Using: Area = π × R²\n");

            Console.WriteLine($"Periemter of cicrle: {circ.perimeter(x)}");
            Console.WriteLine("Using: Perimeter = 2πR\n\n");

            //Rectangle
            Rectangle rect = new Rectangle();

            Console.WriteLine("Rectangle Calculations:");
            Console.WriteLine("Input your rectangles height: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nInput your rectangles width: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"Area of rectangle: {rect.area(x, y)}");
            Console.WriteLine("Using: Area = h x w\n");

            Console.WriteLine($"Periemter of rectangle: {rect.perimeter(x, y)}");
            Console.WriteLine("Using: Perimeter = 2(a+b)\n\n");

            //Triangle
            Triangle tri = new Triangle();

            Console.WriteLine("Triangle Calculations:");
            Console.WriteLine("Input the length of your triangles first side: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nInput the length of your triangles second side: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nInput the length of your triangles third side: ");
            z = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"Area of triangle: {tri.area(x, y, z)}");
            Console.WriteLine("Using:    s = (a + b + c) / 2");
            Console.WriteLine("then: area = sqaureroot((s*(s-a)*(s-b)*(s-c))\n");

            Console.WriteLine($"Periemter of triangle: {tri.perimeter(x, y, z)}");
            Console.WriteLine("Using: Perimeter = a + b + c");

            Console.WriteLine("\n\n= = = = = = = = = = = = = = = = = = = = = = = = = ");
            Console.WriteLine("\nThat is all.");
            Console.WriteLine("Thanks for using the program.");
            Console.WriteLine("Press ENTER to quit.");
            Console.ReadLine();
        }
    }
}
