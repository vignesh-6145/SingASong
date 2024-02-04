

using Microsoft.AspNetCore.Mvc;
using SingASongData.Models;

namespace SingASong.Controllers
{
    public class Admin : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Reports()
        {
            return View();
        }
        public IActionResult Manage()
        {
            MockTrackRepository trackRepository = new MockTrackRepository();
            List<Track> tracks = trackRepository.GetTracks();
            return View(tracks);
        }
        [HttpGet]
        public IActionResult EditTrack(int id)
        {
            MockTrackRepository trackRepository = new MockTrackRepository();
            Track track = trackRepository.GetTrack(id);
            return View(track);
        }
    }
}
