using System;
namespace RPG
{
    public abstract class Monstre : Entite
    {
        public Monstre(string nom) : base(nom)
        {
            this.nom = nom;
            
        }
        public int XpDonner()
        {
            return this.xp;
        }

        
    }
}        
