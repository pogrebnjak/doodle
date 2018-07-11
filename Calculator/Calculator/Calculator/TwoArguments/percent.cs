namespace Calculator.TwoArguments
{
    public class percent : ICalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return (firstArgument/100) + (secondArgument+100);
        }
    }
}
