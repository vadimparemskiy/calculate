using NUnit.Framework;


namespace calculate.Tests.ArgumentsTest
{

    [TestFixture]
    public class divisionTest
    {
        [TestCase(7, 0, 1)]
        [TestCase(8, 4, 2)]
        [TestCase(14, -7, -2)]
        public void CalculateDivisionTestStrong(double firstValue, double secondValue, double expected)
        {
            ITwoArgumentCalculator calculator = new division();
            double result = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, result);

        }
    }
}