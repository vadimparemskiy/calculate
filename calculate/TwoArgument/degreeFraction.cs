
namespace calculate
{
    public class degreeFraction : ITwoArgumentCalculator
    {
        /// <summary>
        /// degreeFraction count
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns>
        /// firstArgument
        /// secondArgument
        /// </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return System.Math.Pow(firstArgument, 1/ secondArgument);
        }
    }
}
