using Microsoft.AspNetCore.Mvc;

namespace AlmostEmpty3_1StarterCode.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Index";
            return View();
        }
        public IActionResult About()
        {
            ViewData["Title"] = "About";
            return View();
        }
    }
}