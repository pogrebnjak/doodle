using System;

namespace Calculator.OneArgument
{
    public class Tangent : IOoneCalculator
    {
        /// <summary>
        /// calculate tan(x) functions
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns>
        /// resturns result tan(x)
        /// </returns>
        public double Calculate(double firstArgument)
        {
            return Math.Tan(firstArgument);
        }
    }
}
