
namespace calculate
{
    public class sin : IOneArgumentCalculator
    {
        public double CalculateArg(double oneArgument)
        {
            return System.Math.Sin(oneArgument);
        }

    }
}
