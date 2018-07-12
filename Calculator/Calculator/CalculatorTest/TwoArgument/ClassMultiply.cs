using Calculator.TwoArguments;
using NUnit.Framework;

namespace CalculatorTest
{
    public class ClassMultiply
    {

        [TestFixture]
        public class MultiplyTests
        {
            [Test]

            public void MultiplyTest()
            {
                var calculator = new Multiply();
                Assert.AreEqual(3, calculator.Calculate(3, 1));
            }
        }
    }
}
