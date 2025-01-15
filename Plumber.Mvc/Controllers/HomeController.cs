using Microsoft.AspNetCore.Mvc;

namespace Plumber.Mvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
