using Calculator.OneArgument;
using NUnit.Framework;

namespace CalculatorTest.OneArgument
{
    [TestFixture]
    public class CosineTests
    {


        [TestCase(1, 0.54)]
        [TestCase(0.5, 0.877)]
        [TestCase(0.7, 0.764)]

        public void ModuleTest(double value, double expected)
        {
            var calculator = new Cosine();
            var actualResult = calculator.Calculate(value);
            Assert.AreEqual(expected, actualResult, 0.001);

        }
    }
}

