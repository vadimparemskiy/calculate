
namespace calculate
{
    public class addition : ITwoArgumentCalculator
    { 
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument + secondArgument;
        }
    }
}