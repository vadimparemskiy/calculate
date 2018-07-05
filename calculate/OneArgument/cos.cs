
namespace calculate
{
    public class cos : IOneArgumentCalculator
    {
        public double Calculate(double oneArgument)
        {
            return System.Math.Cos(oneArgument);
        }

    }
}