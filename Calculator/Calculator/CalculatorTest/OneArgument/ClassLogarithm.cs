using System;
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
            IOoneCalculator calculator = OneArgumentFactory.CreateCalculator("Logarithm");
            double result = calculator.Calculate(value);
            Assert.AreEqual(expected, result, 0.01);
        }

        [TestCase(-1)]
        [TestCase(0)]
        public void ExceptionLessThanZeroTest(double firstArgument)
        {
            var calculator = new Logarithm();
            Assert.Throws<Exception>(() => calculator.Calculate(firstArgument));
        }
    }
}


