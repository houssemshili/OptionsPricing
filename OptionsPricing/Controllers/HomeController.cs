using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OptionsPricing.Models;
using OptionsPricing.Utils;

namespace OptionsPricing.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.InvariantCulture;
            return View();
        }

        [HttpPost]
        public ActionResult Index([Bind(Include = "OptionType,StockPrice,StrikePrice,TimeToMaturity,StandardDeviationOfUnderlyingStock,Risk")] OptionsPricingModel optionsPricingModel)
        {
            optionsPricingModel.Result = Math.Round(OptionsPricingCalculation.OptionsPricing(optionsPricingModel),4);
            return View(optionsPricingModel);
        }
    }
}