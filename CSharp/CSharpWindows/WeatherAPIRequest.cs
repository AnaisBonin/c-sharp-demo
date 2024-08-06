using System.Net.Http;
using System.Threading.Tasks;

namespace CSharpWindows
{
    public class WeatherAPIRequest
    {
        private readonly string APIUrl = "http://www.infoclimat.fr/public-api/gfs/json?_ll=45.16667,5.71667&_auth=BB4DFAB%2BXH4DLltsAHZWfwNrVGENewcgBXkCYVszAn9SMFMxB2JUMFc%2FUy5QfwIzWXRQNwo0BzkBZANjCXtVKQRkA2cAYlw6A2tbOwA4Vn0DL1QpDTMHIAV5AmxbNgJ%2FUjBTNgdmVChXPVMxUH4CNVlrUC8KKgc%2BAWUDZglmVT8EYwNvAGtcOgNsWyYAL1ZkAzZUZg0wBz4FNQIwWz4CZVJiUzIHN1Q3Vz9TL1BpAjRZY1A0CjcHNwFkA2UJe1UpBB4DFAB%2BXH4DLltsAHZWfwNlVGoNZg%3D%3D&_c=678ad57f8799bb77c802ed9f3aee5420";

        public async Task<string> GetWeatherDataJsonAsync()
        {
            using (var client = new HttpClient())
            {
                var result = await client.GetAsync(APIUrl);
                return await result.Content.ReadAsStringAsync();
            }
        }
    }
}
