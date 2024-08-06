using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace CSharpWindows
{
    public class WeatherAPIService : IWeatherAPIService
    {
        private readonly WeatherAPIRequest _apiRequest;

        public WeatherAPIService()
        {
            _apiRequest = new WeatherAPIRequest();
        }

        public List<WeatherAPIModule> GetWeatherData()
        {
            List<WeatherAPIModule> weatherDataList = new List<WeatherAPIModule>();
            string json = _apiRequest.GetWeatherDataJsonAsync().Result;

            JObject data = JObject.Parse(json);

            foreach (var property in data.Properties())
            {
                if (DateTime.TryParse(property.Name, out DateTime dateTime))
                {
                    var temperatureK = property.Value["temperature"]?["sol"];
                    if (temperatureK != null)
                    {
                        double temperatureC = (double)temperatureK - 273.15;
                        weatherDataList.Add(new WeatherAPIModule
                        {
                            Time = dateTime,
                            TemperatureC = temperatureC
                        });
                    }
                }
            }

            return weatherDataList;
        }
    }
}
