using System;

namespace ConvoiVehicules
{
    public class CamionBache : Camion
    {

        private int _emptyWeight;

        //Constructeur
        public CamionBache(int emptyWeight)
        {
            _emptyWeight = emptyWeight;
        }
    }
}
