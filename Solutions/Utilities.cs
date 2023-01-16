using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    internal class Utilities
    {
        public const string Cookie = "53616c7465645f5f248ca3f69a2098a3d5a2f808309e44767c7f8077b304afe9f7aeeeccb2c324c54a3d664c3105e459da0de2a3c6b0d18449d41ea78ac544f3";
        public const int Year = 2022;

        public static async Task SaveDataToFileFromWeb(int day, int year = Year, string cookie = Cookie)
        {
            string filename = GetFilename(day);
            if (!File.Exists(filename))
            {
                var uri = new Uri("https://adventofcode.com");
                var cookies = new CookieContainer();
                cookies.Add(uri, new System.Net.Cookie("session", cookie));
                using var file = new FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.None);
                using var handler = new HttpClientHandler() { CookieContainer = cookies };
                using var client = new HttpClient(handler) { BaseAddress = uri };
                using var response = await client.GetAsync($"/{year}/day/{day}/input");
                using var stream = await response.Content.ReadAsStreamAsync();
                await stream.CopyToAsync(file);
            }
        }

        static string GetFilename(int dayNumber) 
        {
            return $"Day{dayNumber : 00}Data";
        }

    }
}
