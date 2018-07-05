

namespace calculate
{
    public class tan : IOneArgumentCalculator
    {
        public double Calculate(double oneArgument)
        {
            return System.Math.Tan(oneArgument);
        }
    }
}
