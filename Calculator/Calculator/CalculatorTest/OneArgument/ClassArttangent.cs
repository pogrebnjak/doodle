using Calculator.OneArgument;
using NUnit.Framework;

namespace CalculatorTest.OneArgument
{

    [TestFixture]
    public class ArttangentTests
    {


        [TestCase(10, 1.471)]
        [TestCase(15, 1.504)]
        [TestCase(20, 1.520)]

        public void ArttangentTest(double value, double expected)
        {
            var calculator = new Arctangent();
            var actualResult = calculator.Calculate(value);
            Assert.AreEqual(expected, actualResult, 0.001);

        }
    }
}




