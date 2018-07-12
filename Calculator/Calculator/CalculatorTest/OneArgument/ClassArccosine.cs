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
            var calculator = new Arccosine();
            var actualResult = calculator.Calculate(value);
            Assert.AreEqual(expected, actualResult, 0.001);

        }
    }
}