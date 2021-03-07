using System;
using System.Threading;

namespace DM
{
    class Program
    {
        static void Main(string[] args)
        {
            //initialisation de la loop
            bool isRunning = true;
            ConsoleKeyInfo action;

            //introduction et mise en forme.
            Console.Clear();
            Console.WriteLine($"Welcom to the convoy gestion program !");
            Thread.Sleep(2000);
            Console.WriteLine($"here, you will be able to create different cars, truck, bus, and everyting you want to fill your need for speed(no bad jokes here)");
            Thread.Sleep(4000);
            Console.WriteLine($"every vehicles will be at your convoy, that will always be running and working, with a maximal speed.");
            Thread.Sleep(6000);
            Console.WriteLine($"please note that you can theoricly possess many convoy if you want to expand your production, but create a new convoy is now experimental and is still not implemanted in the program.");
            Thread.Sleep(6000);
            Console.WriteLine($"okay ! let's start : ");
            Thread.Sleep(4000);

            //créaton du convoi.
            Convoy convoy1 = new Convoy("convoy1");

            //Début de la loop principale
            while(isRunning)
            {
                //texte de choix des actions
                Console.Clear();
                Console.WriteLine($"please press one of these key to select your actions :\n");
                Console.WriteLine($"A- Add a new vehicle");
                Console.WriteLine($"Z- show all my vehicles");
                Console.WriteLine($"E- show maximal speed of my convoy");
                Console.WriteLine($"R- quit program");

                //détection de l'input
                action = Console.ReadKey();

                if(action.Key == ConsoleKey.A)
                {
                    //appelle de la fonction d'ajout de vehicule
                    Console.Clear();
                    Convoy.AddVehicle();
                }
                else if(action.Key == ConsoleKey.Z)
                {
                    //affichage du convoi.
                    Console.Clear();
                    Console.WriteLine($"convoy : {convoy1.ToString()}");
                    Thread.Sleep(3000);
                }
                else if(action.Key == ConsoleKey.E)
                {
                    //la partie qui appelle la fonction de calcule de la vitesse maximal, ayant révélé de crash au dernier moment, le temps manquait et il a été décide qu'elle ne serait pas intégré.
                    /*Console.Clear();                                 
                    int minimalSpeed;
                    minimalSpeed = Convoy.ConvoyMaxSpeed();
                    Console.WriteLine($"vitesse du convoi : {minimalSpeed}");
                    Thread.Sleep(3000);*/
                }
                else if(action.Key == ConsoleKey.R)
                {
                    //affichage et initialisation du programme de fin de programme
                    Console.Clear();
                    bool isStillChoosing = true;
                    Console.WriteLine("you are about to quit the program, are you sure about that ? your progression won't be saved !\nA- yes                   Z- no");

                    //début de la loop de fin de programme.
                    while(isStillChoosing)
                    {
                        //détection de l'input.
                        Console.Clear();
                        ConsoleKeyInfo endInput = Console.ReadKey();

                        if(endInput.Key == ConsoleKey.A)
                        {
                            //fin de la loop de choix et de la loop principale
                            Console.Clear();
                            Console.WriteLine("thanks for testing our program, have a nice day !");
                            Thread.Sleep(2000);
                            isStillChoosing = false;
                            isRunning = false;
                        }
                        if(endInput.Key == ConsoleKey.Z)
                        {
                            //fin de la loop de choix, retour au début de la loop principale
                            Console.Clear();
                            isStillChoosing = false;
                        }
                    }
                }
            }
        }

        public static void AddConvoy()
        {
            //experimentale, ajout d'un nouveau convoi(n'est pas appellé).
            
            Console.WriteLine("enter the name of your new convoy : ");
            string name = Console.ReadLine();

            Convoy convoy1 = new Convoy(name);
        }
    }
}
