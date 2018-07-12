namespace Calculator.TwoArguments
{
    public class percent : ICalculator
    {
        /// <summary>
        /// calculate x+y% functions
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns>
        /// resturns result x+y%
        /// </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return (firstArgument/100) * (secondArgument+100);
        }
    }
}
