using System;
using NUnit.Framework;

namespace calculate.Tests.FactoryTest
{
    public class TwoArgumentsFactoryTest
    {
        [TestCase("addition", typeof(addition))]
        [TestCase("sabtraction", typeof(sabtraction))]
        [TestCase("multyplication", typeof(multyplication))]
        [TestCase("division", typeof(division))]
        [TestCase("buttonDegree", typeof(degree))]
        [TestCase("buttonDegreeFraction", typeof(degreeFraction))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = TwoArgumentsFactory.CreateCalculator(name);

            Assert.IsInstanceOf(type, calculator);

        }
    }

}