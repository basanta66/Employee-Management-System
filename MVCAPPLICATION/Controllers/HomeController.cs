using Microsoft.AspNetCore.Mvc;
using MVCAPPLICATION.Models;
using System.Diagnostics;

namespace MVCAPPLICATION.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Basu()
        {

            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Content()
        {
            return Content("This is the output returned when action is return type is Content.");
        }
        public JsonResult json()
        {
            return Json(new { name = "Basanta", lastname = "Lamsal" });
        }
        public IActionResult Partial()
        {
            return PartialView("Partial"); // layout is discarded
        }
        public IActionResult Download()
        {
            return File("~/Textfile.txt", "text/plain", "Textfile.txt");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}