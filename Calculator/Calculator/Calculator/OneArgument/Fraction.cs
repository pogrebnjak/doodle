using System;
namespace Calculator.OneArgument
{
    public class Fraction : IOoneCalculator
    {
        /// <summary>
        /// calculate 1/x functions
        /// </summary>
        /// <param name="firstArgument"></param> 
        ///Check x 
        ///if x ==0
        ///then error
        /// <returns>
        /// resturns result 1/x
        /// </returns>
        public double Calculate(double firstArgument)
        {
            if (firstArgument == 0)
            {
                throw new Exception("Деление на 0");
            }
                       return (1/firstArgument);

        }
    }
}