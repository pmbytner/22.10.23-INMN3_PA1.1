using Microsoft.AspNetCore.Mvc;

namespace _22._10._23_INMN3_PA1._1.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Test";
            return View();
        }
        public IActionResult KonkretnaAkcja(string imię, uint id = 1)
        {
            ViewData["Title"] = "Test - Jakaś Akcja";
            ViewData["Imię"] = imię;
            ViewBag.Id = id;

            return View();
        }
    }
}
