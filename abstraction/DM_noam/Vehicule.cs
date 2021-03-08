using System;


namespace ConvoiVehicules
{
    public abstract class Vehicule
    {

        private int _immatriculation;
        private int _emptyWeight;
        private float _charge;
        private int _maximalCharge;

        //Constructeur
        public Vehicule(int immatriculation, int emptyWeight, float charge, int maximalCharge)
        {

            _immatriculation = immatriculation;
            _emptyWeight = emptyWeight;
            _charge = charge;
            _maximalCharge = maximalCharge;
        }

        public override string ToString()
        {
            return $"Immatriculation : {_immatriculation}, Poids à vide : {_emptyWeight}, charge : {_charge}, charge maximale {_maximalCharge}";
        }
    }
}
