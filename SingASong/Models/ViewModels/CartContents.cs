namespace SingASong.Models.ViewModels
{
    public class CartContents
    {
        public IEnumerable<CartItem> items;
        public decimal CartPrice { get; set; }  
    }
}
