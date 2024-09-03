using Microsoft.AspNetCore.Mvc;
using PriceQuoteApp.Models;
using System.Diagnostics;

namespace PriceQuoteApp.Controllers
{
    public class PriceQuatationController : Controller
    {
        private readonly ILogger<PriceQuatationController> _logger;

        public PriceQuatationController(ILogger<PriceQuatationController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            PriceQuotation model = new PriceQuotation();
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
