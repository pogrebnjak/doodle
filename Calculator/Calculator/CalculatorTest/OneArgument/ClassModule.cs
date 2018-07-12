using Calculator.OneArgument;
using NUnit.Framework;

namespace CalculatorTest.OneArgument
{
    [TestFixture]
    public class ModuleTests
    {


        [TestCase(1, 1)]
        [TestCase(100, 100)]
        [TestCase(-1000, 1000)]

        public void ModuleTest(double value, double expected)
        {
            var calculator = new Module();
            var actualResult = calculator.Calculate(value);
            Assert.AreEqual(expected, actualResult, 0.001);

        }
    }
}

