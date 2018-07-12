using Calculator.OneArgument;
using NUnit.Framework;

namespace calculator.Test.OneArgument
{
    [TestFixture]
    public class ExpTests
    {
        [TestCase(0, 1)]
        [TestCase(1, 2.718)]
        [TestCase(2, 7.389)]
        public void FirstTest(double value, double expected)
        {
            var calculator = new Exp();
            var actualResult = calculator.Calculate(value);
            Assert.AreEqual(expected, actualResult, 0.001);
        }
    }
}