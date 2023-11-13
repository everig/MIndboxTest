using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures.UnitTests
{
    internal class CircleTests
    {
        [TestCase(-1)]
        [TestCase(-5)]
        public void SquareTest_ShouldReturnException(double radius)
        {
            Assert.Throws<ArgumentException>(() => new Circle(radius));
        }
        [TestCase(2, 12.56)]
        [TestCase(1, 3.14)]
        [TestCase(12, 452.16)]
        public void SquareTest(double radius, double expected)
        {
            double result = new Circle(radius).GetSquare();
            Assert.AreEqual(expected, result);
        }
    }
}
