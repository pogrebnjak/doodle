﻿using Calculator.TwoArguments;
using NUnit.Framework;

namespace CalculatorTest
{

    public class ClassSubstraction
        {

            [TestFixture]
            public class SubstractionTests
            {
                [Test]

                public void SubstractionTest()
                {
                    var calculator = new Substraction();
                    Assert.AreEqual(2, calculator.Calculate(3, 1));
                }
            }
        }

    }

