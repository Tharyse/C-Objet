using System;
namespace RPG
{
    public class Tank : Personnage
    {
        public Tank(string nom) : base(nom)
        {
            pointDeVieActu = 35;
            pointDeVieMax = 35;
            degatMin = 14;
            degatMax = 17;
        }   
    }
}        
