using NUnit.Framework;


namespace calculate.Tests.ArgumentsTest
{

    [TestFixture]
    public class tanTest
    {
        [TestCase(0, 0)]
        [TestCase(0, 180)]
        [TestCase(0, 360)]
        public void CalculateSinTestStrong(double OneArgument, double expected)
        {
            IOneArgumentCalculator calculator = new tan();
            double result = calculator.CalculateArg(OneArgument);
            Assert.AreEqual(expected, result);

        }
    }
}
