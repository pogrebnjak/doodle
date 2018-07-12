using System;

namespace Calculator.OneArgument
{
    public class Exp : IOoneCalculator
    {
        /// <summary>
        /// calculate exp^x functions
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns>
        /// resturns result exp^x
        /// </returns>
        public double Calculate(double firstArgument)
        {
            return Math.Exp(firstArgument);
        }
    }
}
