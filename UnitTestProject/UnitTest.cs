using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OptionsPricing.Models;
using OptionsPricing.Utils;
using Moq;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestCall()
        {
            var optionsPricingModel = new Mock<OptionsPricingModel>("Call", 50, 55, 1, 0.2, 0.09);
            var result = OptionsPricingCalculation.OptionsPricing(optionsPricingModel.Object);
            result = Math.Round(result, 4);
            Assert.AreEqual(3.8617, result);
        }

        [TestMethod]
        public void TestPut()
        {
            var optionsPricingModel = new Mock<OptionsPricingModel>("Put", 50, 55, 1, 0.2, 0.09);
            var result = OptionsPricingCalculation.OptionsPricing(optionsPricingModel.Object);
            result = Math.Round(result, 4);
            Assert.AreEqual(4.1279, result);
        }
    }
}
