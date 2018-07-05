
using NUnit.Framework;


namespace calculate.Tests.ArgumentsTest
{

    [TestFixture]
    public class additionTest
    {
        [TestCase(7, 0,7)]
        [TestCase(3,4, 7)]
        [TestCase(14,-7,7)]
        public void CalculateAdditionTestStrong(double firstValue,double secondValue, double expected)
        {
            ITwoArgumentCalculator calculator = new addition();
            double result = calculator.Calculate(firstValue,secondValue);
            Assert.AreEqual(expected, result);

        }
    }
}