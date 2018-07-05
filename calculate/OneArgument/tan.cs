

namespace calculate
{
    public class tan : IOneArgumentCalculator
    {
        /// <summary>
        /// Tan count
        /// </summary>
        /// <param name="oneArgument"></param>
        /// <returns>
        /// oneArgument
        /// </returns>
        public double CalculateArg(double oneArgument)
        {
            return System.Math.Tan(oneArgument);
        }
    }
}
