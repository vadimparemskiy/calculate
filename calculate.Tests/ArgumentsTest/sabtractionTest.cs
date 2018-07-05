using NUnit.Framework;


namespace calculate.Tests.ArgumentsTest
{

    [TestFixture]
    public class sabtractionTest
    {
        [TestCase(7, 0, 7)]
        [TestCase(5, 4, 1)]
        [TestCase(14, 2, 12)]
        public void CalculateSabtractionTestStrong(double firstValue, double secondValue, double expected)
        {
            ITwoArgumentCalculator calculator = new sabtraction();
            double result = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, result);

        }
    }
}