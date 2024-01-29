using Microsoft.AspNetCore.Mvc;

namespace SingASong.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Payment()
        {
            return View();
        }
    }
}
