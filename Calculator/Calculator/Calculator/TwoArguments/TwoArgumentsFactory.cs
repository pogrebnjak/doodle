using System;

namespace Calculator.TwoArguments
{
    public class TwoArgumentsFactory
    {
        public static ICalculator CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "Multiply":
                    return  new Multiply();
                case "Division":
                    return  new Division();
                case "Add":
                    return  new Add();
                case "Substraction":
                    return  new Substraction();
                case "Log":
                    return new Log();
                case "RootCube":
                    return new RootCube();
                case "Powerxy":
                    return new Powerxy();
                case "SquareAdd":
                    return new SquareAdd();
                case "SquareSum":
                    return new SquareSum();
                case "percent":
                    return new percent();
                case "negativeDegree":
                    return new negativeDegree();
                case "SquareDifference":
                    return new SquareDifference();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
