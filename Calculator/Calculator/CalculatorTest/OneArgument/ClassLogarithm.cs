using Calculator.OneArgument;
using NUnit.Framework;

namespace CalculatorTest.OneArgument
{

    [TestFixture]
    public class LogarithmTests
    {


        [TestCase(1, 0)]
        [TestCase(100, 4.605)]
        [TestCase(1000, 6.907)]

        public void LogarithmTest(double value, double expected)
        {
            var calculator = new Logarithm();
            var actualResult = calculator.Calculate(value);
            Assert.AreEqual(expected, actualResult, 0.001);

        }
    }
}

