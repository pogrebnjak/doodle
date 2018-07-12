using System;
using Calculator.OneArgument;
using NUnit.Framework;

namespace CalculatorTest.OneArgument
{

    [TestFixture]
    public class ArcsineTests
    {


        [TestCase(0.5, 0.523)]
        [TestCase(0.6, 0.643)]
        [TestCase(0.7, 0.775)]

        public void ArcsineTest(double value, double expected)
        {
            IOoneCalculator calculator = OneArgumentFactory.CreateCalculator("Arcsine");
            double result = calculator.Calculate(value);
            Assert.AreEqual(expected, result, 0.01);
        }

        [TestCase(-1.1)]
        [TestCase(1.1)]
        public void ExceptionLessThanZeroTest(double firstArgument)
        {
            var calculator = new Arcsine();
            Assert.Throws<Exception>(() => calculator.Calculate(firstArgument));
        }
    }
}

