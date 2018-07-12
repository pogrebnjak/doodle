using System;
namespace Calculator.OneArgument
{
    public class Indicative : IOoneCalculator
    {
        /// <summary>
        /// calculate 2^x functions
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns>
        /// resturns result 2^x
        /// </returns>
        public double Calculate(double firstArgument)
        {
            return Math.Pow(2, firstArgument);
        }
    }
}