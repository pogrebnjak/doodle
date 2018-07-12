using System;

namespace Calculator.TwoArguments
{
    public class RootCube : ICalculator
    {
        /// <summary>
        /// calculate (x^1/y) functions
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns>
        /// resturns result (x^1/y)
        /// </returns>
        public double Calculate(double firstArgument,double secondArgument)
        {
            return Math.Pow(firstArgument,(1/secondArgument));

        }
    }
}
