namespace SingASong.Models.ViewModels
{
    public class CartItem
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public string Name { get; set; }
        public decimal Discount { get; set; }
        public int UserId { get; set; }
    }
}