using System;
namespace RPG
{
    public class Sorcier : Personnage
    {
        public Sorcier(string nom) : base(nom)
        {
            pointDeVieActu = 35; 
            pointDeVieMax = 35;
            degatMin = 4;
            degatMax = 7;
        }
    }
}    