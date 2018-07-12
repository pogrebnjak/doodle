using System;

namespace Calculator.OneArgument
{
    public class Root : IOoneCalculator
    {
        /// <summary>
        /// calculate Root(x) functions
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns>
        /// resturns result Root(x)
        /// </returns>
        public double Calculate(double firstArgument)
        {
            return Math.Sqrt(firstArgument);

        }
    }
}
