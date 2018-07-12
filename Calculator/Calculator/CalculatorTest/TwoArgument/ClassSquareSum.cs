using Calculator.TwoArguments;
using NUnit.Framework;

namespace Calculator.Test.TwoArgument
{
    [TestFixture]
    public class SquareSumTests
    {
        [TestCase(6, 6, 144)]
        [TestCase(13, 5, 324)]
        [TestCase(7, 7, 196)]
        public void FirstTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new SquareSum();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult, 0.001);

        }
    }
}
