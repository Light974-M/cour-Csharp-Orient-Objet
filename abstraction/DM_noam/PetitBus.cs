using System;
    
namespace ConvoiVehicules
{
    public class PetitBus : Vehicule
    {
        private int _emptyWeight;

        //Constructeur
        public PetitBus(int emptyWeight)
        {
            _emptyWeight = emptyWeight;
        }
    }
}
