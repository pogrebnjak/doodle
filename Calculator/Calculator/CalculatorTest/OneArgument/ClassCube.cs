using Calculator.OneArgument;
using NUnit.Framework;

namespace calculator.Test.OneArgument
{
    [TestFixture]
    public class CubeTests
    {
        [TestCase(2, 8)]
        [TestCase(3, 27)]
        [TestCase(1, 1)]
        public void FirstTest(double value, double expected)
        {
            var calculator = new Cube();
            var actualResult = calculator.Calculate(value);
            Assert.AreEqual(expected, actualResult, 0.001);
        }
    }
}