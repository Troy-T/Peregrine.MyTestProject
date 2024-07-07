using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace MyTestProject
{
    [TestFixture]
    class CalcTest
    {
        [Test]
        public void TestCalcAdd()
        {
            Calc c = new Calc();
            double x = 4.0;
            double y = 5.0;
            double expectedValue = 9.0;
            double actualValue = c.Add(x, y);
            ClassicAssert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void TestCalcSubstract()
        {
            Calc c = new Calc();
            double x = 6.0;
            double y = 3.0;
            double expectedValue = 3.0;
            double actualValue = c.Subtract(x, y);
            ClassicAssert.AreEqual(expectedValue, actualValue);
        }
    }
}