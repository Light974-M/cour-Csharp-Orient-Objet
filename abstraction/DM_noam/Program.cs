using System;

namespace ConvoiVehicules
{
    class Program
    {
        static void Main(string[] args)
        {
         
           
            PetitBus petitBus = new PetitBus();
            CamionCiterne camionCiterne = new CamionCiterne();
            CamionBache camionBache = new CamionBache();

           

            Vehicule vehicule = new Vehicule();
            Console.WriteLine(vehicule.ToString());

            Vehicule[] vehicules = new Vehicule[] { camionBache, camionCiterne, petitBus };

            public void PetitBus(int emptyWeight)
            {
                emptyWeight = 4;
            }

            public void CamionCiterne(int emptyWeight)
            {
                emptyWeight = 3;
            }

            public void CamionBache(int emptyWeight)
            {
                emptyWeight = 4;
            }

            for (int i = 0; i < vehicules.Length; i++)
            {
                Console.WriteLine(vehicules[i] + $"Immatriculation: { _immatriculation}, Poids à vide: { _emptyWeight}, charge: { _charge}, charge maximale { _maximalCharge}";

                
                Console.WriteLine(shapes[i].DisplayShape());
            }

        }

        public class PetitBus(int immatriculation, float maxSpeed) : Vehicule
        {
            private int _immatriculation;
            private float _maxSpeed;
        }

        public class CamionCiterne : Camion
        {
            private int _immatriculation;
            private float _maxSpeed;
        }

        public class CamionBache : Camion
        {
            private int _immatriculation;
            private float _maxSpeed;
        }


      

    }
}
