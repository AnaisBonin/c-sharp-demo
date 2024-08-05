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
                Console.WriteLine("Please choose an option:");
                Console.WriteLine("1. Check weather API");
                Console.WriteLine("2. End terminal");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        WeatherService weatherService = new WeatherService();
                        var weatherData = weatherService.GetWeatherData();

                        foreach (var data in weatherData)
                        {
                            Console.WriteLine($"Time: {data.Time}, Temperature at 2m: {data.TemperatureC:F2}°C");
                        }

                        break;

                    case "2":
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please choose 1 or 2.");
                        break;
                }
            }
        }
    }
}
