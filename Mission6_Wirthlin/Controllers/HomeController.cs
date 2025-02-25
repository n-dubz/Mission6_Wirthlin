
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Builder;


namespace Mission6_Wirthlin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Renders Views/Home/Index.cshtml
            return View();
        }

        public IActionResult GetToKnowJoel()
        {
            // Renders Views/Home/GetToKnowJoel.cshtml
            return View();
        }
    }
}
