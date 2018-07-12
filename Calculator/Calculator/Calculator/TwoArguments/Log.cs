using System;

namespace Calculator.TwoArguments
{
    public class Log : ICalculator
    {
        /// <summary>
        /// calculate logx(y) functions
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns>
        /// resturns result logx(y)
        /// </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Log(firstArgument,secondArgument);

        }
    }
}
