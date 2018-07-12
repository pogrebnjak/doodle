using System;
using Calculator.OneArgument;
using NUnit.Framework;

namespace CalculatorTest.OneArgument
{

    [TestFixture]
    public class ArccosineTests
    {


        [TestCase(0.5, 1.047)]
        [TestCase(0.7, 0.795)]
        [TestCase(0.8, 0.643)]

        public void ArccosineTest(double value, double expected)   
            {
                IOoneCalculator calculator = OneArgumentFactory.CreateCalculator("Arccosine");
                double result = calculator.Calculate(value);
                Assert.AreEqual(expected, result, 0.01);
            }

        [TestCase(-1.1)]
        [TestCase(1.1)]
        public void ExceptionLessThanZeroTest(double firstArgument)
        {
            var calculator = new Arccosine();
            Assert.Throws<Exception>(() => calculator.Calculate(firstArgument));
        }
    }
}

