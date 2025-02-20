using Microsoft.AspNetCore.Mvc;

namespace Mission6_Wirthlin.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/Index
        public IActionResult Index()
        {
            // Displays "The Joel Hilton Film Collection" and Joel's image.
            return View();
        }

        // GET: /Home/GetToKnowJoel
        public IActionResult GetToKnowJoel()
        {
            // Displays links to Quick Wits Comedy and Baconsale, plus the Baconsale image.
            return View();
        }
    }
}