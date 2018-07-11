using System;

namespace Calculator.OneArgument
{
    public class Fraction : IOoneCalculator
    {
        public double Calculate(double firstArgument)
        {
            return (1/firstArgument);
        }
    }
}
