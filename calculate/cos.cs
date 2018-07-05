using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculate
{
    public class Cos : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return System.Math.Cos(firstArgument);
        }

    }
}