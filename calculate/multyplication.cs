using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculate
{
    class multyplication : ITwoArgumentCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument * secondArgument;
        }
    }
}
