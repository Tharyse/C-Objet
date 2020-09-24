using System;
namespace RPG
{
    public class Assassin : Personnage
    {
        public Assassin(string nom) : base(nom)
        {
            pointDeVieActu = 35; 
            pointDeVieMax = 35;
            degatMin = 4;
            degatMax = 7;
            
        }
    }
}    