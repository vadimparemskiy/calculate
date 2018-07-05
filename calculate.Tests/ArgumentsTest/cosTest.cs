
using NUnit.Framework;


namespace calculate.Tests.ArgumentsTest
{
    
        [TestFixture]
        public class cosTest
        {
            [TestCase(0, 1)]
            [TestCase(90, 0)]
            [TestCase(180, -1)]
            public void CalculateCosTestStrong(double OneArgument, double expected)
            {
                IOneArgumentCalculator calculator = new cos();
                double result = calculator.CalculateArg(OneArgument);
                Assert.AreEqual(expected, result);

            }
        }
}

