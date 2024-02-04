using Microsoft.AspNetCore.Mvc;
using SingASong.Models;
using SingASongData.Models;
using System.Diagnostics;

namespace SingASong.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Thankyoupage()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Shop()
        {
            MockTrackRepository TrackRepository = new MockTrackRepository();
            List<Track> items = TrackRepository.GetTracks();
            return View(items);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
