using System;

namespace Calculator.OneArgument
{
    public class Logarithm : IOoneCalculator 
    {
        public double Calculate(double firstArgument)
        {
            if (firstArgument == 0 || firstArgument == -1)
            {
                throw new Exception("Does't exsist");
            }
            return Math.Log(firstArgument);
      
        }
    }
}
