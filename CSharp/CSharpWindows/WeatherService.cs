using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace CSharpWindows
{
    public class WeatherService
    {
        private readonly string endpoint = "http://www.infoclimat.fr/public-api/gfs/json?_ll=45.16667,5.71667&_auth=UkhTRAN9ByVUeVdgUiQAKQRsAzYNe1RzUS1XNA9nVisDYVU3UzYHY1I6Ui9XeAQ1U34OaVlnAz0DZlAwWCpXK1IyUzcDYQdhVDxXN1JqACsEKAN%2BDTNUc1EtVzIPfFYyA35VNVM2B3tSP1IzV28EL1N%2FDm9ZYQM5A2JQP1gzVzJSOVMxA2EHelQkVzNSZABmBDcDNw1hVD1RZldjDzFWPAM2VWNTNwd7UjVSNFdnBDZTZw5mWW8DMgN%2FUChYTFdHUixTdwMiBzBUfVcoUjcAagRj&_c=a53180c9b2e97a2e4d59e303f7bff2a2";

        public List<WeatherData> GetWeatherData()
        {
            List<WeatherData> weatherDataList = new List<WeatherData>();

            using (var client = new HttpClient())
            {
                var result = client.GetAsync(endpoint).Result;
                var json = result.Content.ReadAsStringAsync().Result;

                JObject data = JObject.Parse(json);

                foreach (var property in data.Properties())
                {
                    if (DateTime.TryParse(property.Name, out DateTime dateTime))
                    {
                        var temperatureK = property.Value["temperature"]?["2m"];
                        if (temperatureK != null)
                        {
                            double temperatureC = (double)temperatureK - 273.15;
                            weatherDataList.Add(new WeatherData
                            {
                                Time = dateTime,
                                TemperatureC = temperatureC
                            });
                        }
                    }
                }
            }

            return weatherDataList;
        }
    }
}
