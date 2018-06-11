using System;

namespace Calculator.TwoArguments
{
    public class Log : ICalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Log(firstArgument,secondArgument);

        }
    }
}
