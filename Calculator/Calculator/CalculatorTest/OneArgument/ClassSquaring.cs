using Calculator.OneArgument;
using NUnit.Framework;

namespace CalculatorTest.OneArgument
{
    [TestFixture]
    public class SquaringTests
    {
        [TestCase(2, 4)]
        [TestCase(3, 9)]
        [TestCase(4, 16)]
        public void SquaringTest(double value, double expected)
        {
            var calculator = new Squaring();
            var actualResult = calculator.Calculate(value);
            Assert.AreEqual(expected, actualResult, 0.001);

        }
    }
}

