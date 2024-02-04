using System.ComponentModel.DataAnnotations;

namespace SingASong.Models
{
    public class Provider
    {
        public int ProviderID { get; set; }
        public string Name { get; set; } = null!;

    }
}