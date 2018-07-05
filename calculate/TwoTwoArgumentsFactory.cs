using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculate
{
    class TwoTwoArgumentsFactory
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
                default:
                    throw new Exception("Неизвестная операция");            }
       }
    }
}

