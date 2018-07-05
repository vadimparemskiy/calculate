using NUnit.Framework;


namespace calculate.Tests.ArgumentsTest
{

    [TestFixture]
    public class multyplicationTest
    {
        [TestCase(7, 0, 0)]
        [TestCase(3, 4, 12)]
        [TestCase(14, 2, 28)]
        public void CalculateMultyplicationTestStrong(double firstValue, double secondValue, double expected)
        {
            ITwoArgumentCalculator calculator = new multyplication();
            double result = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, result);

        }
    }
}