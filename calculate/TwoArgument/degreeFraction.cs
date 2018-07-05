
namespace calculate
{
    public class degreeFraction : ITwoArgumentCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return System.Math.Pow(firstArgument, 1/ secondArgument);
        }
    }
}
