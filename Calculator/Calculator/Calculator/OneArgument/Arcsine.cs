using System;

namespace Calculator.OneArgument
{
    public class Arcsine : IOoneCalculator
    {
        public double Calculate(double firstArgument)
        {
            if (firstArgument < -1 || firstArgument > 1)
            {
                throw new Exception("Не существует");
            }
            return Math.Asin(firstArgument);
        }
    }
}
