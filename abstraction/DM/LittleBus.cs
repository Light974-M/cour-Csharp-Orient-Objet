using System;

namespace DM
{
    class LittleBus : Vehicle
    {
        //constructeur des bus avec immatriculation demandé.
        public LittleBus(string immatriculation)
        {
            _emptyMass = 4;
            _immatriculation = immatriculation;
            _maxSpeed = 150;
        }

        //première surcharge affichant la masse total.
        protected override double TotalMass(double charge, int maxCharge)
        {
            return charge + maxCharge;
        }

        //surcharge tostring.

        public override string ToString()
        {
            return $"-immatriculation : {_immatriculation} \n-emptyMass : {_emptyMass} \n-charge : {_charge} \n-maxCharge : {_maxCharge}";
        }
    }
}