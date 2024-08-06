using System;

namespace CSharpMac
{
    // Classe static: ne contient que des méthodes statiques
    public static class UserInteraction
	{
		public static void WelcomeUsers()
		{
            Console.WriteLine("Bienvenue dans notre application console!");
        }

		public static string ObtainUserName()
		{
            Console.Write("Veuillez entrer votre nom: ");
			string userName = Console.ReadLine();

            while (userName == null || userName.Length < 2)
            {
                Console.Write("Veuillez entrer un nom valide : ");
				userName = Console.ReadLine();
            }

			return userName;
        }

		public static int ObtainUserAge()
		{
			Console.Write("Veuillez entrer votre âge: ");
			int userAge;
			while (!int.TryParse(Console.ReadLine(), out userAge))
			{
				Console.Write("Veuillez entrer un âge valide: ");
			}

			return userAge;
		}

		public static void PrintUserStatus(string status)
		{
            Console.WriteLine("Vous êtes " + status);
        }

		public static void WelcomeUserWithName(string name)
			{
				Console.WriteLine($"Bonjour, {name}!");
			}

		public static void EndProgram()
		{
            Console.WriteLine("Appuyez sur une touche pour terminer...");
            Console.ReadKey();
        }
	}
}

