using System;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TimeManagement
{
    public static class TimeService
    {

        // The DateTime class is the most commonly used date class in C#.
        // It represents a specific date and time and has many properties and methods that allow you to perform operations on it.
        // DateTime objects can be created using various constructors, which accept parameters such as year, month, day, hour, minute, second, and millisecond.
        public static DateTime GetCurrentTime()
        {
            return DateTime.Now;

        }

        // The DateTime class also provides various methods to format dates in different ways.
        // For example, the ToString method can format a DateTime object as a string.
        // The following code formats the date in the “dd MMM yyyy” format (e.g., “11 Mar 2023”):

        // string formattedDate = date1.ToString("dd MMM yyyy");

        public static string GetTodaysDate()
        {
            return DateTime.Today.ToString("dd MM yyyy");

        }

        public static DateTime GetUtcNow()
        {
            return DateTime.UtcNow;
        }

        // The TimeSpan class represents a duration of time rather than a specific date and time.
        // It can perform calculations involving dates and times, such as adding or subtracting time intervals from DateTime objects.
        // TimeSpan objects can be created using various constructors, which accept parameters such as hours, minutes, seconds, and milliseconds.
        public static TimeSpan GetTimeSpan()
        {
            //This code creates a TimeSpan object representing 1 hour and 30 minutes.
            TimeSpan duration = new(1, 30, 0);

            return duration;
        }

        public static int GetHour()
        {
            DateTime date = DateTime.Now;

            Console.WriteLine("Today is: " + date.ToLongDateString());
            return date.Hour;
        }

        public static void PrintFromDate()
        {
            DateTime date = DateTime.Now;

            Console.WriteLine("Time Date: " + date);
            Console.WriteLine("Long Date: " + date.ToLongDateString());
            Console.WriteLine("Short Date: " + date.ToShortDateString());
            Console.WriteLine("Special Date dd MM yyyy: " + date.ToString("dd MM yyyy"));
            Console.WriteLine("Special Date dd MMMM yyyy: " + date.ToString("dd MMMM yyyy"));
            Console.WriteLine("Time of day: " + date.TimeOfDay);
            Console.WriteLine("Hour of day: " + date.Hour);
            Console.WriteLine("Add one month - toString U: " + date.AddMonths(1).ToString("U"));
        }

        public static void PrintFromToday()
        {
            DateTime today = DateTime.Today;

            Console.WriteLine("Today Date: " + today);
            Console.WriteLine("Long time: " + today.ToLongTimeString());
            Console.WriteLine("Short time: " + today.ToShortTimeString());

            Console.WriteLine("Add 2 days: " + today.AddDays(2));

            Console.WriteLine("Day of week: " + today.DayOfWeek);
            Console.WriteLine("Day of year: " + today.DayOfYear); 
        }
    }
}
