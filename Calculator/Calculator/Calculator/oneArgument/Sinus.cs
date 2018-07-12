using System;

namespace Calculator.OneArgument
{
    public class Sinus : IOoneCalculator
    {
        /// <summary>
        /// calculate sinus(x) functions
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns>
        /// resturns result sinus(x)
        /// </returns>
        public double Calculate(double firstArgument)
        {
            return Math.Sin(firstArgument);

        }
    }
}
