
namespace calculate
{
    public class sin : IOneArgumentCalculator
    {
        public double Calculate(double oneArgument)
        {
            return System.Math.Sin(oneArgument);
        }

    }
}
