using Microsoft.AspNetCore.Mvc;
using SingASong.Clients;
using SingASong.Models.ViewModels;

namespace SingASong.Controllers
{
    public class CartController : Controller
    {
        CartClient client { get; set; }
        public CartController()
        {
           client = new CartClient();
        }
        [Route("{UserID:int}")]
        public IActionResult Index(int UserID)
        {
            var items = client.GetCartItems(UserID);
            var price = items.Sum(record => record.Price-record.Discount);
            var cartContent = new CartContents();
            cartContent.items = items;
            cartContent.CartPrice = price;
            return View(cartContent);
        }
        [Route("Payment/{UserID:int}")]
        public IActionResult Payment(int UserID)
        {
            var items = client.GetCartItems(UserID);
            var price = items.Sum(record => record.Price - record.Discount);
            var cartContent = new CartContents();
            cartContent.items = items;
            cartContent.CartPrice = price;
            return View(cartContent);
        }
    }
}
