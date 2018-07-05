

namespace calculate
{
    public class division : ITwoArgumentCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument / secondArgument;
        }
    }
}
