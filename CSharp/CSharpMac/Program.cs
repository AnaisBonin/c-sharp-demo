using System;

namespace CSharpMac
{
    class Program
    {
        static void Main(string[] args)
        {
            UserService userService = new();

            // Class UserEntity
            UserEntity user1 = new();

            // Struct User
            User user2;

            string[] seatsAvailable = { "A2", "B4", "C2" };

            // Appeler une méthode static d'une classe static : l'appeler via la Classe directement. On n'instancie jamais une classe static.
            UserInteraction.WelcomeUsers();

            user1.UserName = UserInteraction.ObtainUserName();
            UserInteraction.WelcomeUserWithName(user1.UserName);

            user2.name = UserInteraction.ObtainUserName();
            UserInteraction.WelcomeUserWithName(user2.name);

            user1.UserAge = UserInteraction.ObtainUserAge();

            // Static methods + use of userService methode
            UserInteraction.PrintUserStatus(userService.DefineUserStatus(user1.UserAge ?? 18));

            Console.WriteLine(user2.name + " you can take seat number " + seatsAvailable[0]);
            UserInteraction.EndProgram();
        }
    }
}
