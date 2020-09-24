using System;
namespace RPG
{
    public class Fourmix : Monstre
    {
        public Fourmix(string nom) : base(nom)
        {
            this.nom = nom;
            this.pointDeVieActu = 50; 
            this.pointDeVieMax = 50;
            this.degatMin = 7;
            this.degatMax = 10;
            this.xp = 9;
        }
        
    }
}        
