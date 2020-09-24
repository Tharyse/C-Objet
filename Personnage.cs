using System;
namespace RPG
{
     
    public abstract class Personnage : Entite
    {
        protected int niveau, experience;

        public Personnage(string nom) : base(nom)
        {
            this.nom = nom;
            niveau = 1;
            experience = 0;
        }

        public void gagnerExperience(int experience)
        {
            this.experience += experience;
            while (this.experience >= experienceRequise())
            {
                niveau ++;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(this.nom + " a atteint le niveau " + niveau + " !");
                Console.WriteLine();

                pointDeVieActu = pointDeVieMax;

                Random pointDeVie = new Random();
                pointDeVieMax += pointDeVie.Next(3,6);

                Random degMin = new Random();
                degatMin += degMin.Next(2,3);

                Random degMax = new Random();
                degatMax += degMax.Next(3,6);
            }
        }

        public double experienceRequise()
        {
            return Math.Round(4 * (Math.Pow(niveau, 3) / 5));
        }
        
        public string Caracteristique()
        {
            return this.nom + "\n" +
                "Point de vie : " + pointDeVieActu + "/" + pointDeVieMax + "\n" +
                "Niveau : " + niveau + "\n" +
                "Point d'experience : (" + experience + "/" + experienceRequise() + ")\n" +
                "Dégats : [min " + degatMin + " - max " + degatMax + "]";
        }
    }

}