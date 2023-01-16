using Microsoft.AspNetCore.Mvc;

namespace Multishop.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
