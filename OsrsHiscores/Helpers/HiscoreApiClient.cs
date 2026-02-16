using System;
using System.Threading.Tasks;
using System.Net.Http;

namespace OsrsHiscores.Helpers
{
    public class HiscoreApiClient
    {

        private static readonly HttpClient _httpClient = new HttpClient
        {
            Timeout = TimeSpan.FromSeconds(10)
        };

        public static async Task<string> FetchRawAsync(string userName)
        {
            string url = HiscoreUrlBuilder.BuildPlayerHiscoreUrl(userName);
            var response = await _httpClient.GetAsync(url);
            Console.WriteLine(response.StatusCode);
            var raw = await response.Content.ReadAsStringAsync();
            return raw;
        }
    }
}