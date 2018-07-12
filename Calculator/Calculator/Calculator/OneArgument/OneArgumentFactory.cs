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
                case "Exp":
                    return new Exp();
                case "Indicative":
                    return new Indicative();
                case "Indicative10":
                    return new Indicative10();
                case "Cosine":
                    return new  Cosine();
                case "Tangent":
                    return new Tangent();
                case "Negative":
                    return new Negative();
                case "Fraction":
                    return new Fraction();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
