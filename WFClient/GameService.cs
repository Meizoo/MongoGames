using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

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
                using (var response = await client.GetAsync(_uri))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var productJsonString = await response.Content.ReadAsStringAsync();

                        return JsonConvert.DeserializeObject<List<Game>>(productJsonString);

                    }
                    return null;
                }
            }
        }

        public async Task<Game> GetProduct()
        {
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(String.Format("{0}/{1}", _uri, "Naruto")))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var productJsonString = await response.Content.ReadAsStringAsync();

                        return JsonConvert.DeserializeObject<Game>(productJsonString);

                    }
                    return null;
                }
            }
        }

        public async Task<HttpResponseMessage> AddProduct()
        {
            Game p = new Game();
            p.Name = "Dobra gra";
            p.Developer = "Najlepszy developer";
            p.Publisher = "Najlepszy publisher";
            using (var client = new HttpClient())
            {
                var serializedProduct = JsonConvert.SerializeObject(p);
                var content = new StringContent(serializedProduct, Encoding.UTF8, "application/json");
                return await client.PostAsync(_uri, content);
            }
        }



        public async Task<HttpResponseMessage> UpdateProduct()
        {
            Game p = new Game();
            p.Name = "Dobra gra";
            p.Developer = "Najlepszy developer";
            p.Publisher = "Najlepszy publisher edytowany";

            using (var client = new HttpClient())
            {
                var serializedProduct = JsonConvert.SerializeObject(p);
                var content = new StringContent(serializedProduct, Encoding.UTF8, "application/json");
                return await client.PutAsync(String.Format("{0}/{1}", _uri, "Dobra gra"), content);
            }
        }


        public async Task<HttpResponseMessage> DeleteProduct()
        {
            using (var client = new HttpClient())
            {
                return await client.DeleteAsync(String.Format("{0}/{1}", _uri, "Dobra gra"));
            }
        }
    }
}
