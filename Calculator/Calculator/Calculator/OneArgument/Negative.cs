using System;

namespace Calculator.OneArgument
{
    public class Negative : IOoneCalculator
    {
        public double Calculate(double firstArgument)
        {
            return firstArgument * (-1);
        }
    }
}
