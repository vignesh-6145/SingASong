using Microsoft.AspNetCore.Mvc;
using SingASong.Clients;
using SingASong.Models;
using SingASong.Models.ViewModels;
using System.Diagnostics;

namespace SingASong.Controllers
{
    public class HomeController : Controller
    {
        public static int UserID = 31;
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
        [Route("addToCart/{UserID:int}/Track/{TrackID:int}")]
        public IActionResult addTocart(int UserID, int TrackID)
        {
            var cliet = new CatalogueClient();
            var items = cliet.AddToCart(UserID,TrackID);
            Console.WriteLine($"made addToCart request {items}");
            return RedirectToAction("Shop");
        }
        public IActionResult Shop()
        {
            var client = new CatalogueClient();
            var items = client.GetCatalogueItems();
            return View(items);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
