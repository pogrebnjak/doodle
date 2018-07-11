using System;
namespace Calculator.TwoArguments
{
    public class negativeDegree : ICalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Pow(firstArgument,(secondArgument*(-1)));
        }
    }
}
