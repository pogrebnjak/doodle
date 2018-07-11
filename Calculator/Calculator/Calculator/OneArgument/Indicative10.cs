using System;

namespace Calculator.OneArgument
{
    public class Indicative10 : IOoneCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Pow(10, firstArgument);
        }
    }
}
