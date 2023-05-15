using Microsoft.AspNetCore.Mvc;

namespace P329task2.Controllers.CardsController
{
    public class CardsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
