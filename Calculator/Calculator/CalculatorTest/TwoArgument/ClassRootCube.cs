using Calculator.TwoArguments;
using NUnit.Framework;

namespace Calculator.Test.TwoArgument
{
    [TestFixture]
    public class RootCubeTests
    {
        [TestCase(1, 3, 1)]
        [TestCase(4, 2, 2)]
        [TestCase(27, 3, 3)]
        public void FirstTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new RootCube();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult, 0.001);

        }
    }
}
