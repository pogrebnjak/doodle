﻿using System;

namespace Calculator.TwoArguments
{
    public class Powerxy : ICalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Pow(firstArgument, secondArgument);
        }
    }
}
