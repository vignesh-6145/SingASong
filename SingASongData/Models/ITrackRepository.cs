namespace SingASongData.Models
{
    public interface ITrackRepository
    {
        Track GetTrack(int _);
        List<Track> GetTracks();
        Track AddTrack(Track Track);
    }
}
