using System;

namespace Calculator.OneArgument
{
    public class Arcsine : IOoneCalculator
    {
        /// <summary>
        /// calculate arcsin(x) functions
        /// </summary>
        /// <param name="firstArgument"></param>
        /// check firsyArgument
        /// if firstArgument more than 1 or less -1
        /// then error
        /// <returns>
        /// resturns result arcsin(x) 
        /// </returns>
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
