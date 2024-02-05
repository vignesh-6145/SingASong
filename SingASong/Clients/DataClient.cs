using Newtonsoft.Json.Linq;
using SingASong.Models;
using SingASong.Models.ViewModels;

namespace SingASong.Clients
{
    public class DataClient
    {
        public static CatalogueItem ConvertToCatalogueItem(string str)
        {
            JToken obj = JToken.Parse(str);
            return ConvertToCatalogueItem(obj);
        }
        public static CatalogueItem ConvertToCatalogueItem(JToken obj)
        {
            CatalogueItem item = new CatalogueItem();
            item.ID = int.Parse(obj["id"].ToString());
            item.Name = obj["name"].ToString();
            item.Album = obj["album"].ToString();
            item.Price = decimal.Parse(obj["price"].ToString());

            List<string> Artists = new List<string>();
            var artists = JArray.Parse(obj["artists"].ToString());
            foreach (var artist in artists)
                Artists.Add(artist.ToString());
            item.Artists = Artists;

            List<string> Genres = new List<string>();
            var genres = JArray.Parse(obj["genres"].ToString());
            foreach (var genre in Genres)
                Genres.Add(genre.ToString());
            item.Genres = Genres;

            return item;
        }
        public static CartItem ConvertToCartItem(string str)
        {
            JToken obj = JToken.Parse(str);
            return ConvertToCartItem(obj);
        }
        public static CartItem ConvertToCartItem(JToken obj)
        {
            CartItem item = new CartItem();
            item.Id = int.Parse(obj["id"].ToString());
            item.Name = obj["name"].ToString();
            item.UserId = int.Parse(obj["userID"].ToString());
            item.Price = decimal.Parse(obj["price"].ToString());
            item.Discount = decimal.Parse(obj["discount"].ToString());
            return item;
        }
        public static Album ConvertToAlbum(string str)
        {
            var obj = JObject.Parse(str);
            return ConvertToAlbum(obj);
        }
        public static Album ConvertToAlbum(JToken obj)
        {
            Album Album = new Album();
            Album.AlbumID = int.Parse((string)obj["albumID"]);
            Album.Name = obj["name"].ToString();
            Album.RealeasedOn = DateOnly.Parse(obj["realeasedOn"].ToString());

            Album.ProviderID = int.Parse(obj["providerID"].ToString());
            return Album;
        }
        public static Artist ConvertToArtist(string str)
        {
            var obj = JObject.Parse(str);
            return ConvertToArtist(obj);
        }

        public static Genre ConverToGenre(string str)
        {
            JToken obj = JToken.Parse(str);
            return ConvertToGenre(obj);
        }
        public static Genre ConvertToGenre(JToken Obj)
        {
            return new Genre()
            {
                Id = int.Parse((string)Obj["id"]),
                Name = Obj["name"].ToString()
            };
        }
        public static Artist ConvertToArtist(JToken Obj)
        {
            return new Artist()
            {
                ArtistId = int.Parse(Obj["artistId"].ToString()),
                ArtistName = Obj["artistName"].ToString(),
                DOB = DateOnly.Parse(Obj["dob"].ToString())
            };
        }

        public static Track ConvertToTrack(string str)
        {
            var obj = JObject.Parse(str);
            return ConvertToTrack(obj);

        }
        public static Track ConvertToTrack(JToken obj)
        {
            Track track = new Track();
            track.Name = (string)obj["name"];
            track.TrackId = int.Parse((string)obj["trackId"]);
            track.Price = decimal.Parse((string)obj["price"]);
            track.AlbumId = int.Parse(obj["albumID"].ToString());
            return track;
        }
    }
}
