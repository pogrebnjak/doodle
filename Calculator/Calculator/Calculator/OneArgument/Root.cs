using System;

namespace Calculator.OneArgument
{
    public class Root : IOoneCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Sqrt(firstArgument);

        }
    }
}
