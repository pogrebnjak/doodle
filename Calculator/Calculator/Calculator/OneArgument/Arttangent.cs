using System;

namespace Calculator.OneArgument
{
    public class Arctangent : IOoneCalculator
    {
        /// <summary>
        /// calculate arctan(x) functions
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns>
        /// resturns result arctan(x)
        /// </returns>
        public double Calculate(double firstArgument)
        {
            return Math.Atan(firstArgument);

        }
    }
}
