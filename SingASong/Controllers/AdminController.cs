

using Microsoft.AspNetCore.Mvc;

namespace SingASong.Controllers
{
    public class Admin : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Reports()
        {
            return View();
        }
        public IActionResult Manage()
        {
            return View();
        }
        [HttpGet]
        public IActionResult EditTrack(int id)
        {
            return View();
        }
    }
}
