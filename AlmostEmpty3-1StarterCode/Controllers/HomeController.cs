using Microsoft.AspNetCore.Mvc;

namespace AlmostEmpty3_1StarterCode.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Home";
            return View();
        }
        public IActionResult About()
        {
            ViewData["Title"] = "About";
            return View();
        }
        public IActionResult Explanation()
        {
            ViewData["Title"] = "Why";
            return View();
        }
    }
}