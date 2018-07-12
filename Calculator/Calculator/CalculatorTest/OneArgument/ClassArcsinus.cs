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
            var calculator = new Arcsine();
            var actualResult = calculator.Calculate(value);
            Assert.AreEqual(expected, actualResult, 0.001);

        }
    }
}
