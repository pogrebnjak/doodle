using Calculator.OneArgument;
using NUnit.Framework;

namespace CalculatorTest.OneArgument
{
    [TestFixture]
    public class SinusTests
    {


        [TestCase(60, -0.304)]
        [TestCase(90, 0.893)]
        [TestCase(180, -0.801)]

        public void SinusTest(double value, double expected)
        {
            var calculator = new Sinus();
            var actualResult = calculator.Calculate(value);
            Assert.AreEqual(expected, actualResult, 0.001);

        }
    }
}

