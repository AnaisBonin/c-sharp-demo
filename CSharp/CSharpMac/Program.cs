using System;

namespace CSharpMac
{
    class Program
    {
        static void Main(string[] args)
        {
            UserService UserService = new();

            // Class UserEntity
            UserEntity User1 = new();

            // Struct User
            User User2;

            // privates variable
            string[] _seatsAvailable = { "A2", "B4", "C2" };

            // Appeler une méthode static d'une classe static : l'appeler via la Classe directement. On n'instancie jamais une classe static.
            UserInteraction.WelcomeUsers();

            User1.UserName = UserInteraction.ObtainUserName();
            UserInteraction.WelcomeUserWithName(User1.UserName);

            User2.Name = UserInteraction.ObtainUserName();
            UserInteraction.WelcomeUserWithName(User2.Name);

            User1.UserAge = UserInteraction.ObtainUserAge();

            // Static methods + use of userService methode
            UserInteraction.PrintUserStatus(UserService.DefineUserStatus(User1.UserAge ?? 18));

            Console.WriteLine(User2.Name + " you can take seat number " + _seatsAvailable[0]);
            UserInteraction.EndProgram();
        }
    }
}
