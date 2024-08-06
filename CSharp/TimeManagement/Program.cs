// See https://aka.ms/new-console-template for more information
using TimeManagement;

namespace CSharpMac
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, World!");

            Console.WriteLine("/////////////");
            TimeService.PrintFromDate();
            Console.WriteLine("/////////////");

            Console.WriteLine("************");
            TimeService.PrintFromToday();
            Console.WriteLine("************/");

            Console.WriteLine("Appuyez sur une touche pour terminer...");
            Console.ReadKey();
        }
    }
}
