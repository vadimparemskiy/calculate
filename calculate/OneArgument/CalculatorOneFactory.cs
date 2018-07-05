using System;


namespace calculate
{
    class CalculatorOneFactory 
    {
        public static IOneArgumentCalculator CreateCalculator(string calculateName)
        {
            switch (calculateName)
            {
                case "Sin":
                    return new sin();
                case "Cos":
                    return new cos();
                case "Tan":
                    return new tan();
                case "buttonRadical":
                    return new radical();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
