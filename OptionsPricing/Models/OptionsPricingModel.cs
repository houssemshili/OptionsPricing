using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OptionsPricing.Models
{
    public class OptionsPricingModel
    {
        public OptionsPricingModel()
        { }

        public OptionsPricingModel(string pOptionType, double pStockPrice, double pStrikePrice, double pTimeToMaturity
            , double pStandardDeviationOfUnderlyingStock, double pRisk)            
        {
            this.OptionType = pOptionType;
            this.StockPrice = pStockPrice;
            this.StrikePrice = pStrikePrice;
            this.TimeToMaturity = pTimeToMaturity;
            this.StandardDeviationOfUnderlyingStock = pStandardDeviationOfUnderlyingStock;
            this.Risk = pRisk;
        }

        [Display(Name = "Option Type")]
        public string OptionType { get; set; }

        [Display(Name = "Stock Price")]
        public double StockPrice { get; set; }

        [Display(Name = "Strike Price")]
        public double StrikePrice { get; set; }

        [Display(Name = "Time To Maturity in Years")]
        public double TimeToMaturity { get; set; }

        [Display(Name = "Standard Deviation Of Underlying Stock")]
        public double StandardDeviationOfUnderlyingStock { get; set; }

        [Display(Name = "Risk")]
        public double Risk { get; set; }

        [Display(Name = "Result")]
        public double? Result { get; set; }
    }
}