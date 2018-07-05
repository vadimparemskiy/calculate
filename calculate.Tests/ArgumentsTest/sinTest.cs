
using NUnit.Framework;


namespace calculate.Tests.ArgumentsTest
{

    [TestFixture]
    public class sinTest
    {
        [TestCase(0, 0)]
        [TestCase(90, 1)]
        [TestCase(180, 0)]
        public void CalculateSinTestStrong(double OneArgument, double expected)
        {
            IOneArgumentCalculator calculator = new sin();
            double result = calculator.CalculateArg(OneArgument);
            Assert.AreEqual(expected, result);

        }
    }
}
