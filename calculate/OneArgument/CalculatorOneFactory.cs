using System;


namespace calculate
{
    class CalculatorOneFactory 
    {
        /// <summary>
        /// Switch One Argument Calculator
        /// </summary>
        /// <param name="calculateName"></param>
        /// <returns>
        /// Method
        /// </returns>
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
