using Calculator.TwoArguments;
using NUnit.Framework;

namespace Calculator.Test.TwoArgument
{
    [TestFixture]
    public class LogTests
    {
        [TestCase(10, 2, 3.321)]
        [TestCase(2, 5, 0.43)]
        [TestCase(4, 2, 2)]
        public void FirstTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new Log();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult, 0.001);

        }
    }
}
