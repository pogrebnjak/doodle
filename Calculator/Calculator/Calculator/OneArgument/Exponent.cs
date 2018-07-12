using System;

namespace Calculator.OneArgument
{
    public class Exp : IOoneCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Exp(firstArgument);
        }
    }
}
