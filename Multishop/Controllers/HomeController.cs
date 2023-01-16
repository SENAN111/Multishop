using Microsoft.AspNetCore.Mvc;

namespace Multishop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
