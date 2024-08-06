using System.Collections.Generic;

namespace CSharpWindows
{
    public interface IWeatherAPIService
    {
        List<WeatherAPIModule> GetWeatherData();
    }
}
