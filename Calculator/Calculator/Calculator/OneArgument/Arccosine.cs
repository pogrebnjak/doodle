using System;

namespace Calculator.OneArgument
{
    public class Arccosine : IOoneCalculator
    {
        public double Calculate(double firstArgument)
        {
            if (firstArgument < -1 || firstArgument > 1)
            {
                throw new Exception("Не существует");
            }
            return Math.Acos(firstArgument);
        }
    }
}
