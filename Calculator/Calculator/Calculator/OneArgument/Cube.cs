using System;

namespace Calculator.OneArgument
{
    public class Cube : IOoneCalculator
    {
        /// <summary>
        /// calculate x^3 functions
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns>
        /// resturns result x^3
        /// </returns>
        public double Calculate(double firstArgument)
        {
            return Math.Pow(firstArgument, 3);

        }
    }
}
