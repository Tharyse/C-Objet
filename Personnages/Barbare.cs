using System;
namespace RPG
{
    public class Barbare : Personnage
    {
        public Barbare(string nom) : base(nom)
        {
            pointDeVieActu = 35; 
            pointDeVieMax = 35;
            degatMin = 9;
            degatMax = 12;
        }
    }
}        
