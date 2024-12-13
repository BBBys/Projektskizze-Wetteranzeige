using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace WeatherApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string apiKey = "DEIN_API_SCHLUESSEL";
            string city = "Stadt";
            string url = $"http://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                JObject weatherData = JObject.Parse(responseBody);
                Console.WriteLine(weatherData);
            }
        }
    }
}