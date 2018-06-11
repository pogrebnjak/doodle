using System;
namespace Calculator.OneArgument
{
    public class Indicative : IOoneCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Pow(2, firstArgument);
        }
    }
}