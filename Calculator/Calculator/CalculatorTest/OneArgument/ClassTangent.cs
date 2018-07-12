using Calculator.OneArgument;
using NUnit.Framework;

namespace calculator.Test.OneArgument
{
    [TestFixture]
    public class TangentTests
    {
        [TestCase(0, 0)]
        [TestCase(30, -6.405)]
        [TestCase(5, -3.38)]
        public void FirstTest(double value, double expected)
        {
            var calculator = new Tangent();
            var actualResult = calculator.Calculate(value);
            Assert.AreEqual(expected, actualResult, 0.001);
        }
    }
}
