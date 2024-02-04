namespace SingASong.Models
{
    public class Album
    {
        public int AlbumID { get; set; }
        public string Name { get; set; } = null!;
        public DateOnly? RealeasedOn { get; set; }
        public int ProviderID { get; set; }
        public Provider Provider { get; set; } = null!;
        public ICollection<Track> Tracks { get; set; } = null!;
    }
}
