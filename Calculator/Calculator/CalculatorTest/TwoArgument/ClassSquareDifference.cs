using Calculator.TwoArguments;
using NUnit.Framework;

namespace Calculator.Test.TwoArgument
{
    [TestFixture]
    public class SquareDifferenceTests
    {
        [TestCase(9, 17, -208)]
        [TestCase(17, 1, 288)]
        [TestCase(99, 66, 5445)]
        public void FirstTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new SquareDifference();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult, 0.001);

        }
    }
}
