using System;

namespace Calculator.OneArgument
{
    public class Indicative10 : IOoneCalculator
    {
        /// <summary>
        /// calculate 10^firstArgeument functions
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns>
        /// resturns result 10^firstArgument
        /// </returns>
        public double Calculate(double firstArgument)
        {
            return Math.Pow(10, firstArgument);
        }
    }
}
