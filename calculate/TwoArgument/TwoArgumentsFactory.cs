﻿using System;

namespace calculate
{
    public class TwoArgumentsFactory
    {
        /// <summary>
        /// Method based on name button
        /// </summary>
        /// <param name="calculateName"></param>
        /// <returns>
        /// Calculatorname
        /// </returns>
        public static ITwoArgumentCalculator CreateCalculator(string calculateName)
        {
            switch (calculateName)
            {
               case "addition":
                    return new addition();
                case "sabtraction":
                    return new sabtraction();
                case "multyplication":
                    return new multyplication();
                case "division":
                    return new division();
                case "buttonDegree":
                    return new degree();
                case "buttonDegreeFraction":
                    return new degreeFraction();
                default:
                    throw new Exception("Неизвестная операция");            }
       }
    }
}

