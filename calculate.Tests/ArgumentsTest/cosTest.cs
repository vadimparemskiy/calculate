
using NUnit.Framework;


namespace calculate.Tests.ArgumentsTest
{
    
        [TestFixture]
        public class cosTest
        {
            [TestCase(0, 1)]
            [TestCase(-1, 0)]
            [TestCase(0, -1)]
            public void CalculateCosTestStrong(double OneArgument, double expected)
            {
                IOneArgumentCalculator calculator = new cos();
                double result = calculator.CalculateArg(OneArgument);
                Assert.AreEqual(expected, result);

            }
        }
}

