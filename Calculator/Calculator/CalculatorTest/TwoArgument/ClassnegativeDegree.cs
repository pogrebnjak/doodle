using Calculator.TwoArguments;
using NUnit.Framework;

namespace Calculator.Test.TwoArgument
{
    [TestFixture]
    public class negativeDegreeTests
    {
        [TestCase(2, 1, 0.5)]
        [TestCase(10, 3, 0.001)]
        [TestCase(7, 2, 0.02)]
        public void FirstTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new negativeDegree();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult, 0.001);

        }
    }
}
