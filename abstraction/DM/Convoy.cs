using System;
using System.Threading;

namespace DM
{
    public class Convoy
    {
        //initialisation des arguments.
        private string _convoyName;
        public static Vehicle[] _convoyList;

        //constructeur du convoie avec le nom du convoie demandé.
        public Convoy(string convoyName)
        {
            _convoyName = convoyName;
            _convoyList = new Vehicle[100000000];
        }

        //la fonction d'ajout de vehicule.
        public static void AddVehicle()
        {
            //initialisation de la loop.
            bool isLoopSelectCar = true;
            string chooseCar;

            while(isLoopSelectCar)
            {
                //choix du type de vehicule.

                Console.WriteLine("wich type of vehicle would you create : \n1-little bus \n2-citern truck \n3-bach truck");
                chooseCar = Console.ReadLine();

                //choix du bus.
                if(chooseCar == "1")
                {
                    //choix de l'immatriculation.

                    Console.WriteLine("pick an immatriculation for your new vehicle : ");
                    string newImatriculation = Console.ReadLine();

                    //teste du bon format de l'immatriculation.

                    if(newImatriculation.Length == 9 && newImatriculation[0].GetType() == typeof(System.Char) && newImatriculation[1].GetType() == typeof(System.Char) && newImatriculation[2] == '-' && newImatriculation[3].GetType() == typeof(System.Char) && newImatriculation[4].GetType() == typeof(System.Char) && newImatriculation[5].GetType() == typeof(System.Char) && newImatriculation[6] == '-' && newImatriculation[7].GetType() == typeof(System.Char) && newImatriculation[8].GetType() == typeof(System.Char))
                    {
                        //création du camion et retour au programme principale.

                        LittleBus bus1 = new LittleBus(newImatriculation);
                        Console.WriteLine("immatriculation applied, new vehicle is saved.");
                        Thread.Sleep(3000);
                        isLoopSelectCar = false;
                    }
                    else
                    {
                        //mauvais format de la plaque, retour au choix des vehicules.

                        Console.WriteLine("you haven't choosed the good format for the immatriculation, an immatriculation number is composed like this : XX-999-XX, please retry with this.\n");
                        Thread.Sleep(2000);
                    }
                }

                //choix du camion citerne.
                
                else if(chooseCar == "2")
                {
                    //choix de l'immatriculation.

                    Console.WriteLine("pick an immatriculation for your new vehicle : ");
                    string newImatriculation = Console.ReadLine();

                    //teste du bon format de l'immatriculation.

                    if(newImatriculation.Length == 9 && newImatriculation[0].GetType() == typeof(System.Char) && newImatriculation[1].GetType() == typeof(System.Char) && newImatriculation[2] == '-' && newImatriculation[3].GetType() == typeof(System.Char) && newImatriculation[4].GetType() == typeof(System.Char) && newImatriculation[5].GetType() == typeof(System.Char) && newImatriculation[6] == '-' && newImatriculation[7].GetType() == typeof(System.Char) && newImatriculation[8].GetType() == typeof(System.Char))
                    {
                        //aplication de l'immatriculation, choix de la charge.

                        Console.WriteLine("immatriculation applied.");
                        Thread.Sleep(3000);
                        Console.WriteLine("choose a charge for your truck(max : 10t) :");
                        string newCharge = Console.ReadLine();

                        //boucle testant le bon format de la charge, a savoir, un nombre décimal.

                        for(int i = 0 ; i < newCharge.Length ; i++)
                        {
                            //detection d'un mauvais caractère.

                            if(newCharge[i] != '0' && newCharge[i] != '1' && newCharge[i] != '2' && newCharge[i] != '3' && newCharge[i] != '4' && newCharge[i] != '5' && newCharge[i] != '6' && newCharge[i] != '7' && newCharge[i] != '8' && newCharge[i] != '9' && newCharge[i] != ',')
                            {
                                //erreur, retour au choix des vehicules.

                                Console.WriteLine("that's a wrong number ! plase select a true number, that can contain numbers from 0 to 9 and a ',' for the decimal numbers.\n");
                                Thread.Sleep(2000);
                                break;
                            }

                            //aucun mauvais caractère detecté.

                            if(i+1 == newCharge.Length)
                            {
                                //test de la limite de poid.

                                if(Convert.ToDouble(newCharge) <= 10)
                                {
                                    //charge correcte, création du camion et retour au programme principale.

                                    CiternTruck citern1 = new CiternTruck(newImatriculation, Convert.ToDouble(newCharge));
                                    Console.WriteLine("charge applied, new vehicle is saved");
                                    Thread.Sleep(3000);
                                    isLoopSelectCar = false;
                                }
                                else
                                {
                                    //limite dépassé, retour au chois des vehicules.
                                    Console.WriteLine("you have entered a value that override the truck, you must not get over the max charge (10t)\n");
                                    Thread.Sleep(2000);
                                }
                                
                            }
                        } 
                    }
                    else
                    {
                        //mauvais format de la plaque, retour au choix des vehicules.

                        Console.WriteLine("you haven't choosed the good format for the immatriculation, an immatriculation number is composed like this : XX-999-XX, please retry with this.\n");
                        Thread.Sleep(2000);
                    }
                }

                //choix du camion bache.
                
                else if(chooseCar == "3")
                {
                    //choix de l'immatriculation.

                    Console.WriteLine("pick an immatriculation for your new vehicle : ");
                    string newImatriculation = Console.ReadLine();

                    //teste du bon format de l'immatriculation.

                    if(newImatriculation.Length == 9 && newImatriculation[0].GetType() == typeof(System.Char) && newImatriculation[1].GetType() == typeof(System.Char) && newImatriculation[2] == '-' && newImatriculation[3].GetType() == typeof(System.Char) && newImatriculation[4].GetType() == typeof(System.Char) && newImatriculation[5].GetType() == typeof(System.Char) && newImatriculation[6] == '-' && newImatriculation[7].GetType() == typeof(System.Char) && newImatriculation[8].GetType() == typeof(System.Char))
                    {
                        //aplication de l'immatriculation, choix de la charge.

                        Console.WriteLine("immatriculation applied.");
                        Thread.Sleep(3000);
                        Console.WriteLine("choose a charge for your truck(max : 20t) :");
                        string newCharge = Console.ReadLine();

                        //boucle testant le bon format de la charge, a savoir, un nombre décimal.

                        for(int i = 0 ; i < newCharge.Length ; i++)
                        {
                            //detection d'un mauvais caractère.

                            if(newCharge[i] != '0' && newCharge[i] != '1' && newCharge[i] != '2' && newCharge[i] != '3' && newCharge[i] != '4' && newCharge[i] != '5' && newCharge[i] != '6' && newCharge[i] != '7' && newCharge[i] != '8' && newCharge[i] != '9' && newCharge[i] != ',')
                            {
                                //erreur, retour au choix des vehicules.

                                Console.WriteLine("that's a wrong number ! plase select a true number, that can contain numbers from 0 to 9 and a ',' for the decimal numbers.\n");
                                Thread.Sleep(2000);
                                break;
                            }

                            //aucun mauvais caractère detecté.

                            if(i+1 == newCharge.Length)
                            {

                                 //test de la limite de poid.

                                if(Convert.ToDouble(newCharge) <= 20)
                                {
                                    //charge correcte, création du camion et retour au programme principale.

                                    BachTruck bach1 = new BachTruck(newImatriculation, Convert.ToDouble(newCharge));
                                    Console.WriteLine("charge applied, new vehicle is saved");
                                    Thread.Sleep(3000);
                                    isLoopSelectCar = false;
                                }
                                else
                                {
                                    //mauvais format de la plaque, retour au choix des vehicules.
                                    
                                    Console.WriteLine("you have entered a value that override the truck, you must not get over the max charge (20t)\n");
                                    Thread.Sleep(2000);
                                }
                            }
                        } 
                    }
                    else
                    {
                        //mauvais format de la plaque, retour au choix des vehicules.

                        Console.WriteLine("you haven't choosed the good format for the immatriculation, an immatriculation number is composed like this : XX-999-XX, please retry with this.\n");
                        Thread.Sleep(2000);
                    }
                }
                else
                {
                    //autre caractère entré que les trois input des trois vehicules, retour au choix des vehicules.

                    Console.WriteLine("look... you just type a wrong character, you must type 1, 2, or 3 to select the type of vehicle, try again\n");
                    Thread.Sleep(2000);
                }
            }
        }

        public static int ConvoyMaxSpeed()
        {
            int vitesseMin = 10000000;
            
            for(int i = 0; i < _convoyList.Length; i++)
            {
                if(_convoyList[i]._maxSpeed < vitesseMin)
                {
                    vitesseMin = _convoyList[i]._maxSpeed;
                }
            }

            return vitesseMin;
        }

        public override string ToString()
        {
            return $"convoy : {_convoyList.ToString()}";
        }

    }
}