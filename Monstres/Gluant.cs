using System;
namespace RPG
{
    public class Gluant : Monstre
    {
        public Gluant(string nom) : base(nom)
        {
            this.nom = nom;
            this.pointDeVieActu = 35; 
            this.pointDeVieMax = 35;
            this.degatMin = 4;
            this.degatMax = 6;
            this.xp = 60;
        }
        
    }
}        
