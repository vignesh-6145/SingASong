using Microsoft.AspNetCore.Mvc;

namespace SingASong.Controllers
{
    public class InfoController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
