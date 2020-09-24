using System;
namespace RPG{
    public class Entite{

        protected int degatMin, degatMax, xp, pointDeVieActu, pointDeVieMax, degatSubi;
        protected string nom;
        protected bool estMort = false;
        protected Random random = new Random();

        public Entite(string nom)
        {
            this.nom = nom;
        }

        public string VraiNom()
        {
            return nom;
        }
       
        public void Attaque(Entite uneEntite)
        {
            int degats = random.Next(degatMin, degatMax);
            Console.WriteLine();
            uneEntite.PerdrePointDeVie(degats);
            Console.WriteLine(this.nom + "(" + this.pointDeVieActu + "/" + this.pointDeVieMax + ")" + " attaque : " + uneEntite.nom);
            Console.WriteLine(uneEntite.nom + " a perdu " + degats  + " points de vie");
            Console.WriteLine("Il reste " + uneEntite.pointDeVieActu + " points de vie à " + uneEntite.nom);
            if(uneEntite.estMort)
            {
                Console.WriteLine();
                Console.WriteLine(uneEntite.nom + " est mort");
            }
        }

        protected void PerdrePointDeVie(int degatSubi)
        {
            this.pointDeVieActu -= degatSubi;
            if(this.pointDeVieActu <= 0)
            {
                this.pointDeVieActu = 0;
                estMort = true;
            }
            
        }
        public void Revivre()
        {
            this.estMort = false;
            pointDeVieActu = pointDeVieMax;
        }
        public bool EstMort()
        {
            return this.estMort;
        }
    }
}        
