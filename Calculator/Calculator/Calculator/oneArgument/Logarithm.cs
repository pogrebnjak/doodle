using System;

namespace Calculator.OneArgument
{
    public class Logarithm : IOoneCalculator 
    {
        /// <summary>
        /// calculate ln(x) functions
        /// </summary>
        /// <param name="firstArgument"></param> 
        ///Check firstArgument 
        ///if x == 0 || x == -1
        ///then error
        /// <returns>
        /// resturns result ln(x)
        /// </returns>
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
