using System;

namespace calculate
{
    class TwoArgumentsFactory
    {
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
                    return new degreeFracton();
                default:
                    throw new Exception("Неизвестная операция");            }
       }
    }
}

