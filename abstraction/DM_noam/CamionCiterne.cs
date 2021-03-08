using System;

namespace ConvoiVehicules
{
    public class CamionCiterne : Camion
    {
        private int _emptyWeight;

        //Constructeur
        public CamionCiterne(int emptyWeight)
        {
            _emptyWeight = emptyWeight;
        }
    }
}