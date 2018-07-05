using NUnit.Framework;


namespace calculate.Tests.ArgumentsTest
{

    [TestFixture]
    public class degreeFractionTest
    {
        [TestCase(5, 2, 2.5)]
        [TestCase(10, 2, 5)]
        [TestCase(15, 2, 7.5)]
        public void CalculateDegreeFractionTestStrong(double firstValue, double secondValue, double expected)
        {
            ITwoArgumentCalculator calculator = new degreeFraction();
            double result = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, result);

        }
    }
}