using System;
namespace Calculator.TwoArguments
{
    public class SquareSum : ICalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Pow((firstArgument  + secondArgument), 2);
        }
    }
}
