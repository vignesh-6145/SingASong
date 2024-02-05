using SingASong.Models.ViewModels;
using SingASong.Models;
using Newtonsoft.Json.Linq;

namespace SingASong.Clients
{
    public class CatalogueClient
    {
        APIClient client;
        public CatalogueClient()
        {
            client = new APIClient("https://localhost:7140/api/Catalogue/");
        }
        public  CatalogueItem GetCatalogueItem(int TrackId)
        {
            string GetCatalogueItemURL = $"{TrackId}";
            string ResponseStr = client.MakeGetAPICall(GetCatalogueItemURL);
            return DataClient.ConvertToCatalogueItem(ResponseStr);
        }
        public IEnumerable<CatalogueItem> GetCatalogueItems()
        {

            string ResponseStr = client.MakeGetAPICall("");
            JArray tracks = JArray.Parse(ResponseStr);
            List<CatalogueItem> items = new List<CatalogueItem>();
            foreach (var track in tracks)
            {
                items.Add(DataClient.ConvertToCatalogueItem(track));
            }
            return items;
        }
        public string AddToCart(int UserID, int TracKID)
        {
            string AddToCartURL = $"User/{UserID}/AddToCart/{TracKID}";
            string resp = client.MakePostCall(AddToCartURL);
            return resp;
        }

    }
}
