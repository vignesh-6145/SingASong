using Microsoft.AspNetCore.Mvc;

namespace SingASong.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
