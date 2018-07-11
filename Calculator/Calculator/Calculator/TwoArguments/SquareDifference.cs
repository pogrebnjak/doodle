using System;
namespace Calculator.TwoArguments
{
    public class SquareDifference : ICalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Pow(firstArgument, 2) - Math.Pow(secondArgument, 2);
        }
    }
}
