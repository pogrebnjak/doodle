using System;

namespace Calculator.OneArgument
{
    public class Module : IOoneCalculator
    {
        /// <summary>
        /// calculate |x| functions
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns>
        /// resturns result |x|
        /// </returns>
        public double Calculate(double firstArgument)
        {
            return Math.Abs(firstArgument);

        }
    }
}
