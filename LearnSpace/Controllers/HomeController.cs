using Microsoft.AspNetCore.Mvc;

namespace LearnSpace.Controllers
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
            if (User.IsInRole("Student"))
            {
                return RedirectToAction("Dashboard", "Student");
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
