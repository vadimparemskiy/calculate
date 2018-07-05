

namespace calculate
{
    public class tan : IOneArgumentCalculator
    {
        public double CalculateArg(double oneArgument)
        {
            return System.Math.Tan(oneArgument);
        }
    }
}
