using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace TestShapes
{
    [TestFixture]
    internal class TestOfTestShapes
    {
        //Circle Tests
        [Test]
        public void TestCicleArea()
        {
            Circle circ = new Circle();
            double x = 7.0;
            double expectedValue = 153.938;
            double actualValue = circ.area(x);
            ClassicAssert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void TestCiclePerimeter() 
        {
            Circle circ = new Circle();
            double x = 9.0;
            double expectedValue = 56.5487;
            double actualValue = circ.perimeter(x);
            ClassicAssert.AreEqual(expectedValue, actualValue);
        }

        //Rectangle Tests
        [Test]
        public void TestRectangleArea()
        {
            Rectangle rect = new Rectangle();
            double x = 7.0;
            double y = 4.0;
            double expectedValue = 28.0;
            double actualValue = rect.area(x, y);
            ClassicAssert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void TestRectanglePerimeter()
        {
            Rectangle rect = new Rectangle();
            double x = 6.0;
            double y = 3.0;
            double expectedValue = 18.0;
            double actualValue = rect.perimeter(x, y);
            ClassicAssert.AreEqual(expectedValue, actualValue);
        }

        //Triangle Tests
        [Test]
        public void TestTriangleArea()
        {
            Triangle tri = new Triangle();
            double x = 4;
            double y = 7;
            double z = 9;
            double expectedValue = 13.416;
            double actualValue = tri.area(x, y, z);
            ClassicAssert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void TestTrianglePerimeter()
        {
            Triangle tri = new Triangle();
            double x = 2;
            double y = 5;
            double z = 6;
            double expectedValue = 13.0;
            double actualValue = tri.perimeter(x, y, z);
            ClassicAssert.AreEqual(expectedValue, actualValue);
        }
    }
}
