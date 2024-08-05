using System;

namespace CSharpMac
{
	public class UserInteraction
	{
		public string User { get; set; }

		public UserInteraction()
		{
			this.User = "no one is here!";
		}

		public void WelcomeUser()
		{
            Console.WriteLine("Bienvenue dans notre application console!");
        }

		public void GetUserName()
		{
            Console.Write("Veuillez entrer votre nom: ");
            string userName = Console.ReadLine();

			if (userName != null)
			{
				this.User = userName;
			}
        }

		public void WelcomeName()
		{
            Console.WriteLine($"Bonjour, {this.User}!");
        }
	}
}

