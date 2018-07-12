using System;

namespace Calculator.TwoArguments
{
    public class Powerxy : ICalculator
    {
        /// <summary>
        /// calculate x^y functions
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns>
        /// resturns result x^y
        /// </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Pow(firstArgument, secondArgument);
        }
    }
}
