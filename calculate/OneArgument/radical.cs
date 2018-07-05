
namespace calculate
{
    public class radical : IOneArgumentCalculator
    {
        /// <summary>
        /// Radical count
        /// </summary>
        /// <param name="oneArgument"></param>
        /// <returns>
        /// oneArgument
        /// </returns>
        public double CalculateArg(double oneArgument)
        {
            return System.Math.Sqrt(oneArgument);
        }

    }
}

