using System;
namespace RPG
{
    public class Barde : Personnage
    {
        public Barde(string nom) : base(nom)
        {
            pointDeVieActu = 35; 
            pointDeVieMax = 35;            
            degatMin = 4;
            degatMax = 7;
            
        }
    }
}    