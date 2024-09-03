// Ignore Spelling: App

using Microsoft.AspNetCore.Mvc;
using PriceQuoteApp.Models;
using System.Diagnostics;

namespace PriceQuoteApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            PriceQuotation model = new PriceQuotation();
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(PriceQuotation model)
        {
            if (ModelState.IsValid)
            {
                model.Calculate();
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Reset()
        {
            return RedirectToAction("Index");
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
