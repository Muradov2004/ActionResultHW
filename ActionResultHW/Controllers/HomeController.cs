using ActionResultHW.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ActionResultHW.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //view result
        public IActionResult Index()
        {
            return View();
        }

        //Partial View Result
        public ActionResult Partial()
        {
            return PartialView();
        }

        // Json Result
        public ActionResult Json()
        {
            var data = new { Name = "Hakuna", Age = 42 };
            return Json(data);
        }

        // Redirect
        public ActionResult Redirect()
        {
            return Redirect("https://www.google.com/");
        }

        // Content Result
        public ActionResult Content()
        {
            return Content("salam");
        }

        // Empty Result
        public ActionResult Empty()
        {
            return new EmptyResult();
        }

        // File Result
        public ActionResult File()
        {
            return File("~/Files/example.html", "text/html");
        }

        // RedirectRoute Result
        public ActionResult Redirectroute()
        {
            return RedirectToRoute(new { controller = "Home", action = "Route" });
        }

        public ActionResult Route()
        {
            return View();
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
