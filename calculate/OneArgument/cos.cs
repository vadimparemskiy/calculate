
namespace calculate
{
    public class cos : IOneArgumentCalculator
    {
        public double CalculateArg(double oneArgument)
        {
            return System.Math.Cos(oneArgument);
        }

    }
}