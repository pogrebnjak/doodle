﻿using System;
namespace Calculator.TwoArguments
{
    public class Division : ICalculator
    {
        /// <summary>
        /// calculate x/y functions
        /// </summary>
        /// <param name="firstArgument"></param>
        /// check firsyArgument
        /// if firstArgument more than 0
        /// then error
        /// <returns>
        /// resturns result x/y 
        /// </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
         
        if (secondArgument == 0)
            {
                throw new Exception("Деление на 0");
                    }
                return firstArgument / secondArgument;
        }
    }
}
