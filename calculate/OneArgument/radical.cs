
namespace calculate
{
    public class radical : IOneArgumentCalculator
    {
        public double Calculate(double oneArgument)
        {
            return System.Math.Sqrt(oneArgument);
        }

    }
}

