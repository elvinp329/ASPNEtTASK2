using Microsoft.AspNetCore.Mvc;

namespace P329task2.Controllers.HomeController
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
