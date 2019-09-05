using OptionsPricing.Utils;
using System.ComponentModel.DataAnnotations;

namespace OptionsPricing.Models
{
    public class OptionsPricing
    { 
        [Display(Name = "Option Type")]
        public OptionsType OptionType { get; set; }

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