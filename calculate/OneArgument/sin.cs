
namespace calculate
{
    public class sin : IOneArgumentCalculator
    {
        /// <summary>
        /// Sin count
        /// </summary>
        /// <param name="oneArgument"></param>
        /// <returns>
        /// oneArgument
        /// </returns>
        public double CalculateArg(double oneArgument)
        {
            return System.Math.Sin(oneArgument);
        }

    }
}
