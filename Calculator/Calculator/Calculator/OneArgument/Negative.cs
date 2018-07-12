using System;

namespace Calculator.OneArgument
{
    public class Negative : IOoneCalculator
    {
        /// <summary>
        /// calculate x*-1 functions
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns>
        /// resturns result x*-1
        /// </returns>
        public double Calculate(double firstArgument)
        {
            return firstArgument * (-1);
        }
    }
}
