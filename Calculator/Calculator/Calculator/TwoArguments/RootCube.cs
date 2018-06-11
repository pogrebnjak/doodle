using System;

namespace Calculator.TwoArguments
{
    public class RootCube : ICalculator
    {
        public double Calculate(double firstArgument,double secondArgument)
        {
            return Math.Pow(firstArgument,(1/secondArgument));

        }
    }
}
