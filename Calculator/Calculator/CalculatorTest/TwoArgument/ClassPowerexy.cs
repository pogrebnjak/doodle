using Calculator.TwoArguments;
using NUnit.Framework;

namespace Calculator.Test.TwoArgument
{
    [TestFixture]
    public class powerxyTests
    {
        [TestCase(1, 3, 1)]
        [TestCase(2, 3, 8)]
        [TestCase(4, 2, 16)]
        public void FirstTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new Powerxy();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult, 0.001);

        }
    }
}
