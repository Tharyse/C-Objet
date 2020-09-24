using System;
using System.Collections.Generic;

namespace RPG{
    class Program{

        private static bool victoire = false;
        private static int nbCombat = 0;
        private static Monstre ennemiACombattre;
        private static List<Monstre> monstre = new List<Monstre>();

        public static void PersoCombat(Personnage perso)    
        {
            if(!perso.EstMort())
            {
                //TOUR DU PERSONNAGE
                Console.ForegroundColor = ConsoleColor.Green;  

                perso.Attaque(ennemiACombattre);
                Console.WriteLine();
                Console.WriteLine("---------------------------------------------------------------------------------------------------------");
                Console.WriteLine();
                Console.ReadKey(true);
            }
        }

        public static void Main(string[] args)
        {
            Commencer();
        }
        
        static void Commencer()
        {
            Console.Clear();
            for (int i = 0; i < 10; i++)
            {
                monstre.Add(new Fourmix("Fourmix"));
            }
            for (int i = 0; i < 10; i++)
            {
                monstre.Add(new Gluant("Gluant"));
            }
            for (int i = 0; i < 10; i++)
            {
                monstre.Add(new Gnon("Gnon"));
            }
            for (int i = 0; i < 5; i++)
            {
                monstre.Add(new Griffon("Griffon"));
            }
            for (int i = 0; i < 2; i++)
            {
                monstre.Add(new LordSoupex("Dupeyra"));
            }
            for (int i = 0; i < 8; i++)
            {
                monstre.Add(new Squelette("Poichigeon"));
            }
            Menu();
        }

        static void Jouer(Personnage perso)
        {
            Random random = new Random();
            int index = random.Next(1,46);
            ennemiACombattre = monstre[index];;

            Console.WriteLine("Tu te bas contre : " + ennemiACombattre.VraiNom());
            Console.WriteLine();
            Console.WriteLine("*Appuyer sur Entrez*");
            Console.ReadKey();
            Console.WriteLine();

            victoire = true;
            bool suivant = false;

            while(!ennemiACombattre.EstMort())
            {
                //TOUR DU MONSTRE
                Console.ForegroundColor = ConsoleColor.Red;
                ennemiACombattre.Attaque(perso);

                Console.WriteLine();
                Console.ReadKey(true);

                if(perso.EstMort())
                {
                    victoire = false;
                    break;
                }

                PersoCombat(perso);
            }

            if(victoire)
            {         
                perso.gagnerExperience(ennemiACombattre.XpDonner());

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine();
                Console.WriteLine(perso.Caracteristique());

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine();

                while(!suivant)
                {
                    Console.WriteLine("Salle suivante ? (o/n)");
                    string saisie = Console.ReadLine().ToUpper();
                    if(saisie == "O" || saisie == "")
                    {
                        nbCombat++;
                        Console.WriteLine("Vous rentrer dans la salle " + nbCombat);
                        suivant = true;
                        Jouer(perso);
                    }
                    else if(saisie == "N")
                    {
                       Commencer();
                    }
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("C'est perdu ...");
                Console.WriteLine();
                Console.WriteLine("Vous êtes arrivé jusqu'à la salle" + nbCombat);
                Console.ReadKey();
            }     
        }

        public static void Menu()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Rpg game");
            Console.WriteLine();
            Console.WriteLine("1) Tank");
            Console.WriteLine("2) Barbare");
            Console.WriteLine("3) Barde");
            Console.WriteLine("4) Assassin");
            Console.WriteLine("5) Pyromane");
            Console.WriteLine("6) Sorcier");
            Console.WriteLine();
            Console.WriteLine("0) Quitter (le jeu)");
            Console.WriteLine();
            Console.WriteLine("*Choisissez*");
            string choix = Console.ReadLine();

            switch (choix)
            {
                case "1":
                    Console.WriteLine("Vous incarnez Yan !");
                    Console.WriteLine();
                    Jouer(new Tank("Yan"));
                    break;

                case "2":

                    Console.WriteLine("Vous incarnez David !");
                    Console.WriteLine();
                    Jouer(new Barbare("David"));
                    break;

                case "3":

                    Console.WriteLine("Vous incarnez Paul !");
                    Console.WriteLine();
                    Jouer(new Barde("Paul"));
                    break;

                case "4":

                    Console.WriteLine("Vous incarnez Fiora !");
                    Console.WriteLine();
                    Jouer(new Pyromane("Fiora"));
                    break;

                case "5":

                    Console.WriteLine("Vous incarnez Camille !");
                    Console.WriteLine();
                    Jouer(new Sorcier("Camille"));
                    break;

                case "6":

                    Console.WriteLine("Vous incarnez Hugo !");
                    Console.WriteLine();
                    Jouer(new Assassin("Hugo"));
                    break;

            }
 
        }
    }
}        
