
namespace calculate
{
    public class radical : IOneArgumentCalculator
    {
        public double CalculateArg(double oneArgument)
        {
            return System.Math.Sqrt(oneArgument);
        }

    }
}

