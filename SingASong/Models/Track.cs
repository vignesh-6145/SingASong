using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SingASong.Models
{
    public class Track
    {
        public int TrackId { get; set; }
        public string Name { get; set; }

        public int AlbumId { get; set; }
        public decimal Price { get; set; }  
    }
}
