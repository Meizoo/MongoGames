using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace WFClient
{
    public class GameService
    {
        private readonly string _uri = "http://localhost:52163/game";

        public GameService()
        {
        }

        public async Task<List<Game>> GetAllProducts()
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", "ZGF3aWQ6ZGF3aWQ=");
                using (var response = await client.GetAsync(_uri))
                    return response.IsSuccessStatusCode 
                        ? JsonConvert.DeserializeObject<List<Game>>(await response.Content.ReadAsStringAsync()) 
                        : null;
            }
        }

        public async Task<Game> GetProduct(string id)
        {
            using (var client = new HttpClient())
            using (var response = await client.GetAsync(String.Format("{0}/{1}", _uri, id)))
                return response.IsSuccessStatusCode 
                    ? JsonConvert.DeserializeObject<Game>(await response.Content.ReadAsStringAsync()) 
                    : null;
        }

        public async Task<HttpResponseMessage> AddProduct(Game game)
        {
            var p = game;

            using (var client = new HttpClient())
                return await client.PostAsync(
                    this._uri, 
                    new StringContent(JsonConvert.SerializeObject(p), Encoding.UTF8, "application/json")
                );
        }

        public async Task<HttpResponseMessage> UpdateProduct(Game game)
        {
            var p = game;

            using (var client = new HttpClient())
                return await client.PutAsync(
                    string.Format("{0}/{1}", this._uri, game.Id), 
                    new StringContent(JsonConvert.SerializeObject(p), Encoding.UTF8, "application/json")
                );
        }

        public async Task<HttpResponseMessage> DeleteProduct(string id)
        {
            using (var client = new HttpClient())
                return await client.DeleteAsync(String.Format("{0}/{1}", _uri, id));
        }
    }
}
