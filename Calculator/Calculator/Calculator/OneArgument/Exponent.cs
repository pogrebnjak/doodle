using System;

namespace Calculator.OneArgument
{
    public class Exponent : IOoneCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Exp(firstArgument);
        }
    }
}
