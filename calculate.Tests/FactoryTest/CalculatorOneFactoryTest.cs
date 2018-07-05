using System;
using NUnit.Framework;

namespace calculate.Tests.FactoryTest
{
    public class CalculatorOneFactoryTest
    {
        [TestCase("Sin", typeof(sin))]
        [TestCase("Cos", typeof(cos))]
        [TestCase("Tan", typeof(tan))]
        [TestCase("buttonRadical", typeof(radical))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = CalculatorOneFactory.CreateCalculator(name);

            Assert.IsInstanceOf(type, calculator);

        }
    }
}