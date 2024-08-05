﻿using System;

namespace CSharpMac
{
    class Program
    {
        static void Main(string[] args)
        {
            // private / local variables must be named with _
            int _legalAge = 18;

            UserInteraction userInteraction = new UserInteraction();

            // Afficher un message de bienvenue
            userInteraction.WelcomeUser();

            userInteraction.GetUserName();

            // Saluer l'utilisateur
            userInteraction.WelcomeName();

            // Lire l'âge de l'utilisateur
            Console.Write("Veuillez entrer votre âge: ");
            int userAge;
            while (!int.TryParse(Console.ReadLine(), out userAge))
            {
                Console.Write("Veuillez entrer un âge valide: ");
            }

            // Afficher un message selon l'âge
            if (userAge < _legalAge)
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
