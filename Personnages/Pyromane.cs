using System;
namespace RPG
{
    public class Pyromane : Personnage
    {
        public Pyromane(string nom) : base(nom)
        {
            pointDeVieActu = 35; 
            pointDeVieMax = 35;
            degatMin = 4;
            degatMax = 7;
        }
    }
}