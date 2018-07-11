using System;

namespace Calculator.OneArgument
{
    public class Cosine : IOoneCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Cos(firstArgument);
        }
    }
}
