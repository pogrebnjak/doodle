using System;

namespace Calculator.OneArgument
{
    public class Squaring : IOoneCalculator
    {
        /// <summary>
        /// calculate x^2 functions
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns>
        /// resturns result x^2
        /// </returns>
        public double Calculate(double firstArgument)
        {
            return Math.Pow(firstArgument, 2);

        }
    }
}
