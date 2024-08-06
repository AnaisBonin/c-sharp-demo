using System;

namespace CSharpWindows
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("The options :");
                Console.WriteLine("1. Grenoble Weather API");
                Console.WriteLine("2. Exit");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        IWeatherAPIService weatherService = new WeatherAPIService();
                        var weatherData = weatherService.GetWeatherData();

                        foreach (var data in weatherData)
                        {
                            Console.WriteLine($"Time : {data.Time}");
                            Console.WriteLine($"Temperature : {data.TemperatureC:F2}°C");
                            Console.WriteLine();
                        }

                        break;

                    case "2":
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("1 or 2");
                        break;
                }
            }
        }
    }
}
