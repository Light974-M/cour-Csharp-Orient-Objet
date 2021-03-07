using System;

namespace DM
{
    class BachTruck : Truck
    {
        //constructeur avec immatriculation et charge du camion demandé.
        public BachTruck(string immatriculation, double charge)
        {
            _charge = charge;
            _maxCharge = 20;
            _emptyMass = 4;
            _immatriculation = immatriculation;
            _maxSpeed = 130;
        }

        //fonction de calcul de la vitesse maximal.

        protected override float CacluleVitesseMax(int speed)
        {
            if(_charge <= 4)
            {
                speed = 130;
            }
            else if(_charge > 4 && _charge <= 7)
            {
                speed = 110;
            }
            else if(_charge > 7 && _charge <= 11)
            {
                speed = 90;
            }
            else if(_charge > 11 && _charge <= 14)
            {
                speed = 80;
            }
            else if(_charge > 14)
            {
                speed = 70;
            }

            return speed;
        }

        //surcharge retournant la masse total du vehicule.

        protected override double TotalMass(double charge, int maxCharge)
        {
            return charge + maxCharge;
        }

        //surcharge tostring().

        public override string ToString()
        {
            return $"-immatriculation : {_immatriculation} \n-emptyMass : {_emptyMass} \n-charge : {_charge} \n-maxCharge : {_maxCharge}";
        }
    }
}