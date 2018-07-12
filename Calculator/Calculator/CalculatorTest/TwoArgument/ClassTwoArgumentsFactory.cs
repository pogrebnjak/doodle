using System;
using Calculator.TwoArguments;
using NUnit.Framework;

namespace Calculator.Test.TwoArgument
{
    class TwoArgumentFactoryTests
    {
        [TestCase("Add", typeof(Add))]
        [TestCase("Multiply", typeof(Multiply))]
        [TestCase("RootCube", typeof(RootCube))]
        [TestCase("negativeDegree", typeof(negativeDegree))]
        [TestCase("percent", typeof(percent))]
        [TestCase("SquareAdd", typeof(SquareAdd))]
        [TestCase("Division", typeof(Division))]
        [TestCase("Log", typeof(Log))]
        [TestCase("SquareDifference", typeof(SquareDifference))]
        [TestCase("SquareSum", typeof(SquareSum))]
        [TestCase("Substraction", typeof(Substraction))]
        [TestCase("Powerxy", typeof(Powerxy))]
        public void FirstTest(string name, Type type)
        {
            var calculator = TwoArgumentsFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}
