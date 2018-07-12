using System;
namespace Calculator.TwoArguments
{
    public class SquareDifference : ICalculator
    {
        /// <summary>
        /// calculate (x^2-y^2) functions
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns>
        /// resturns result (x^2-y^2)
        /// </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Pow(firstArgument, 2) - Math.Pow(secondArgument, 2);
        }
    }
}
