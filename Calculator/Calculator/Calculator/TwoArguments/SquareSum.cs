using System;
namespace Calculator.TwoArguments
{
    public class SquareSum : ICalculator
    {
        /// <summary>
        /// calculate (x+y)^2 functions
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns>
        /// resturns result (x+y)^2
        /// </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Pow((firstArgument  + secondArgument), 2);
        }
    }
}
