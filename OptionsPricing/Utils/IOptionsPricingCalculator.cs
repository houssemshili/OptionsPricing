using System;

namespace OptionsPricing.Utils
{
    public interface IOptionsPricingCalculator
    {

        double OptionsPricing(Models.OptionsPricing optionsPricingModel);
        double CND(double X);
        
    }
}