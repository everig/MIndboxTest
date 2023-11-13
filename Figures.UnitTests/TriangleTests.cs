
namespace Figures.UnitTests
{
    public class Tests
    {
        [TestCase(3, 4, 5, 6)]
        [TestCase(5, 5, 5, 10.83)]
        public void SquareTest(double sideA, double sideB, double sideC, double expected)
        {
            double result = new Triangle(sideA, sideB, sideC).GetSquare();
            
            Assert.AreEqual(expected, result);
        }
        [TestCase(1, -1, 0)]
        [TestCase(-5, -1, -2)]
        public void SquareTest_ShouldReturnException(double sideA, double sideB, double sideC)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));    
        }

        [TestCase(3, 4, 5, true)]
        [TestCase(3, 3, 5, false)]
        [TestCase(24, 7, 25, true)]
        public void RightTriangleTest(double sideA, double sideB, double sideC, bool expected)
        {
            bool result = new Triangle(sideA, sideB, sideC).RightTriangle();

            Assert.AreEqual(expected, result);
        }
    }
}