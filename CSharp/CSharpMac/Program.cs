using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Afficher un message de bienvenue
            Console.WriteLine("Bienvenue dans notre application console!");

            // Lire le nom de l'utilisateur
            Console.Write("Veuillez entrer votre nom: ");
            string userName = Console.ReadLine();

            // Saluer l'utilisateur
            Console.WriteLine($"Bonjour, {userName}!");

            // Lire l'âge de l'utilisateur
            Console.Write("Veuillez entrer votre âge: ");
            int userAge;
            while (!int.TryParse(Console.ReadLine(), out userAge))
            {
                Console.Write("Veuillez entrer un âge valide: ");
            }

            // Afficher un message selon l'âge
            if (userAge < 18)
            {
                Console.WriteLine("Vous êtes mineur.");
            }
            else
            {
                Console.WriteLine("Vous êtes majeur.");
            }

            // Fin du programme
            Console.WriteLine("Appuyez sur une touche pour terminer...");
            Console.ReadKey();
        }
    }
}
