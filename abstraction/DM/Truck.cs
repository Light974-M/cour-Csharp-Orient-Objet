using System;

namespace DM
{
    abstract class Truck : Vehicle
    {
        //constructeur avec charge demandé.

        public int SetCharge(int charge)
        {
            string strCharge;

            Console.WriteLine($"insert truck charge to replace {charge}: ");
            
            strCharge = Console.ReadLine();
            charge = Convert.ToInt32(strCharge);
            return charge;
        }

        //fonction abstract de calcul de la vitesse maximal.

        protected abstract float CacluleVitesseMax(int speed);
    }
}