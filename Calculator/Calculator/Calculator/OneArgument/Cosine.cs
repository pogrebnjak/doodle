using System;

namespace Calculator.OneArgument
{
    public class Cosine : IOoneCalculator
    {
        /// <summary>
        /// calculate cos(x) functions
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns>
        /// resturns result cos(x)
        /// </returns>
        public double Calculate(double firstArgument)
        {
            return Math.Cos(firstArgument);
        }
    }
}
