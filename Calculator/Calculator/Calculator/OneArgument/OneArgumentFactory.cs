using System;

namespace Calculator.OneArgument
{
    public class OneArgumentFactory
    {
        public static IOoneCalculator CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "Module":
                    return new Module();
                case "Squaring":
                    return new Squaring();
                case "Logarithm":
                    return new Logarithm();
                case "Sinus":
                    return new Sinus();
                case "Cube":
                    return new Cube();
                case "Root":
                    return new Root();
                case "Arctangent":
                    return new Arctangent();
                case "Arcsine":
                    return new Arcsine();
                case "Arccosine":
                    return new Arccosine();
                case "Exponent":
                    return new Exponent();
                case "Indicative":
                    return new Indicative();

                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
