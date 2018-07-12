using Calculator.TwoArguments;
using NUnit.Framework;

namespace Calculator.Test.TwoArgument
{
    [TestFixture]
    public class SquareAddTests
    {
        [TestCase(4, 2, 20)]
        [TestCase(8, 5, 89)]
        [TestCase(15, 7, 274)]
        public void FirstTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new SquareAdd();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult, 0.001);

        }
    }
}
