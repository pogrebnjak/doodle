using Calculator.TwoArguments;
using NUnit.Framework;

namespace Calculator.Test.TwoArgument
{
    [TestFixture]
    public class percentTests
    {
        [TestCase(100, 10, 110)]
        [TestCase(50, 5, 52.5)]
        [TestCase(8, 1, 8.08)]
        public void FirstTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new percent();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult, 0.001);

        }
    }
}
