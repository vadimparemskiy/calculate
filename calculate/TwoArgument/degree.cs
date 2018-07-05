

namespace calculate
{
    class degree : ITwoArgumentCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return System.Math.Pow(firstArgument, secondArgument);
        }
    }
}
