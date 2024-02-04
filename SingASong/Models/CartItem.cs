namespace SingASong.Models
{
    public class CartItem
    {
        public CartItem()
        {
            Track = new Track();
        }
        public int Id { get; set; }
        public int TrackId { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        public virtual Track Track { get; set; }
        public int Quantity { get; set; }
        public int UserId { get; set; }
    }
}