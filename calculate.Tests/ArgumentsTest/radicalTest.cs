
using NUnit.Framework;


namespace calculate.Tests.ArgumentsTest
{

    [TestFixture]
    public class radicalTest
    {
        [TestCase(4, 2)]
        [TestCase(16, 4)]
        [TestCase(64,8)]
        public void CalculateRadicalTestStrong(double OneArgument, double expected)
        {
            IOneArgumentCalculator calculator = new radical();
            double result = calculator.CalculateArg(OneArgument);
            Assert.AreEqual(expected, result);

        }
    }
}
