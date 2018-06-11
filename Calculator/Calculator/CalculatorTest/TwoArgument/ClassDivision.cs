using Calculator.TwoArguments;
using NUnit.Framework;

namespace CalculatorTest
{
    class ClassDivision
    {
        [TestCase(4,-2,-2)]
        [TestCase(20, 4, 5)]
        [TestCase(-10, -2, 5)]
        public class DivisionTests
        {
            [Test]

            public void DivisionTest()
            {
                var calculator = new Division();
                Assert.AreEqual(3, calculator.Calculate(3, 1));
            }
        }
    }

}