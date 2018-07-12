using Calculator.TwoArguments;
using NUnit.Framework;

namespace CalculatorTest.TwoArgument
{
    public class ClassDivision
    {

        [TestFixture]
        public class DivisionTests
        {


            [TestCase(1, 1, 1)]
            [TestCase(6, 2, 3)]
            [TestCase(9, 3, 3)]

            public void CalculateTest(double firstValue, double secondValue, double expected)
            {
                var calculator = new Division();
                var actualResult = calculator.Calculate(firstValue, secondValue);
                Assert.AreEqual(expected, actualResult, 0.001);

            }
        }
    }
}