using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PartOneSt10456400.Models;

namespace PartOneSt10456400.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult LectureLogin()
        {
            return View();
        }
        public IActionResult Lecture()
        {
            return View();
        }

        public IActionResult LectureRegister()
        {
            return View();
        }

        public IActionResult Coordinator()
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
