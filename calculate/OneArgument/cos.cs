
namespace calculate
{
    public class cos : IOneArgumentCalculator
    {
        /// <summary>
        /// Cos count
        /// </summary>
        /// <param name="oneArgument"></param>
        /// <returns>
        /// oneArgument
        /// </returns>
        public double CalculateArg(double oneArgument)
        {
            return System.Math.Cos(oneArgument);
        }

    }
}