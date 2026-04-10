using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;

//using _01_Api_Rest.Models;
using _01_CL_Achat;

namespace _01_CL_Api_Client
{
    public class ApiClient
    {
        static HttpClient client = new HttpClient();

        //constructeur static est invoqué pour intialiser des élément statiques
        static ApiClient()
        {
            // Remplacer l'url par celle de votre API
            client.BaseAddress = new Uri("https://localhost:7178/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        }

        // Méthode du client API pour communiquer avec l'API
        public static async Task<List<Achat>?> GetAchatsAsync()
        {
            HttpResponseMessage response = await client.GetAsync("api/Achat");

            response.EnsureSuccessStatusCode();

            string json = await response.Content.ReadAsStringAsync();     //on recupere json recupere par l'api

            List<Achat>? result = JsonSerializer.Deserialize<List<Achat>>(json);

            return result; 
        }

        // 2 possibilités 
            //1. on envoie on objet

        public static async Task<Uri> CreateAchatAsync(Achat achat)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("api/Achat", achat);

            response.EnsureSuccessStatusCode();

            return response.Headers.Location;
        }


            //2. on envoie un Json
        public static async Task<Uri> CreateAchatAsyncFromJson(string json)
        {

            StringContent content = new StringContent(json, new MediaTypeHeaderValue("application/json"));

            HttpResponseMessage response = await client.PostAsync("api/Achat", content);

            response.EnsureSuccessStatusCode();

            return response.Headers.Location;
        }

    }
}
