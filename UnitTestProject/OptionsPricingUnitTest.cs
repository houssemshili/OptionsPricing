using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OptionsPricing.Utils;

namespace UnitTestProject
{
    [TestClass]
    public class OptionsPricingUnitTest
    {
        [TestMethod]
        public void TestCall()
        {
            var optionsPricing = new OptionsPricing.Models.OptionsPricing()
            {
                OptionType = OptionsType.Call,
                StockPrice = 50,
                StrikePrice = 55,
                TimeToMaturity = 1,
                StandardDeviationOfUnderlyingStock = 0.2,
                Risk = 0.09
            };
            IOptionsPricingCalculator optionsPricingCalculator = new OptionsPricingCalculator();
            var result = optionsPricingCalculator.OptionsPricing(optionsPricing);

            Assert.AreEqual(3.8617, result);
        }

        [TestMethod]
        public void TestPut()
        {
            var optionsPricing = new OptionsPricing.Models.OptionsPricing()
            {
                OptionType = OptionsType.Put,
                StockPrice = 50,
                StrikePrice = 55,
                TimeToMaturity = 1,
                StandardDeviationOfUnderlyingStock = 0.2,
                Risk = 0.09
            };
            IOptionsPricingCalculator optionsPricingCalculator = new OptionsPricingCalculator();
            var result = optionsPricingCalculator.OptionsPricing(optionsPricing);

            Assert.AreEqual(4.1279, result);
        }
    }
}
