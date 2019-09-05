using System.Globalization;
using System.Web.Mvc;
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
        public ActionResult Index([Bind(Include = "OptionType,StockPrice,StrikePrice,TimeToMaturity,StandardDeviationOfUnderlyingStock,Risk")] Models.OptionsPricing optionsPricingModel)
        {
            IOptionsPricingCalculator optionsPricingCalculator = new OptionsPricingCalculator();
            optionsPricingModel.Result = optionsPricingCalculator.OptionsPricing(optionsPricingModel);
            return View(optionsPricingModel);
        }
    }
}