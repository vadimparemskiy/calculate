using NUnit.Framework;


namespace calculate.Tests.ArgumentsTest
{

    [TestFixture]
    public class degreeTest
    {
        [TestCase(5, 2, 25)]
        [TestCase(10, 2, 100)]
        [TestCase(15, 2, 225)]
        public void CalculateDegreeTestStrong(double firstValue, double secondValue, double expected)
        {
            ITwoArgumentCalculator calculator = new degree();
            double result = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, result);

        }
    }
}