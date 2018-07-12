using System;
using Calculator.OneArgument;
using NUnit.Framework;

namespace calculator.Test.OneArgument
{
    class OneArgumentFactoryTests
    {
        [TestCase("Cosine", typeof(Cosine))]
        [TestCase("Tangent", typeof(Tangent))]
        [TestCase("Arccosine", typeof(Arccosine))]
        [TestCase("Arcsine", typeof(Arcsine))]
        [TestCase("Arctangent", typeof(Arctangent))]
        [TestCase("Sinus", typeof(Sinus))]
        [TestCase("Squaring", typeof(Squaring))]
        [TestCase("Cube", typeof(Cube))]
        [TestCase("Logarithm", typeof(Logarithm))]
        [TestCase("Module", typeof(Module))]
        [TestCase("Exp", typeof(Exp))]
        [TestCase("Fraction", typeof(Fraction))]
        public void FirstTest(string name, Type type)
        {
            var calculator = OneArgumentFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}
