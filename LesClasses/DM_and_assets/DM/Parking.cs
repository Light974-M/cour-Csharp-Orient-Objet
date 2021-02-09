using System;
using System.Threading;


namespace DM
{
    class Parking
    {
        private Cars[] _carCollection;
        private float _pricePerHour;
        private float _moneyOwnedInDay;

        public Parking(Cars[] carCollection, float pricePerHour, float moneyOwnedInDay)
        {
            _carCollection = carCollection;
            _pricePerHour = pricePerHour;
            _moneyOwnedInDay = moneyOwnedInDay;
        }


        public Cars[] AddCar()
        {
            Console.WriteLine("may want you to enter a new car in the collection ? please do so : ");

            bool isValid = false;
            string ownerName = "";
            while(!isValid)
            {
                Console.WriteLine("tell me who is the owner of this awesome new car : ");
                ownerName = Console.ReadLine();

                if(string.IsNullOrEmpty(ownerName))
                {
                    Console.WriteLine($"Error n°3 : the owner can't be nobody, please enter a name and retry.");
                }
                else
                {
                    isValid = true;
                }
            }

            Cars newCar = new Cars(ownerName);

            for(int i = 0; i < _carCollection.Length; i++)
            {
                if(_carCollection[i] == null)
                {
                    _carCollection[i] = newCar;
                    Console.WriteLine($"amazing ! i have noticed everything, the car of {ownerName} is now your !\n (enter)");
                    break;
                }
                
                if(i+1 == _carCollection.Length)
                {
                    Console.WriteLine($"you fool ! the array is full ! i will now destroy the car of {ownerName} !\n (enter)");
                }
            }

            ConsoleKeyInfo pass;
            do
            {
                pass = Console.ReadKey();
            }while(pass.Key != ConsoleKey.Enter);

            return _carCollection;
        }







        public Cars[] DeleteCar()
        {

            string leftCursor = " ";
            string rightCursor = ".";

            ConsoleKeyInfo select3;

            string carPositionInList = Console.ReadLine();

            for(int i = 1; i <= _carCollection.Length; i++)
            {
                if(i.ToString() == carPositionInList && _carCollection[i-1] != null)
                {
                    Console.Clear();
                    do
                    {
                        Console.WriteLine($"you are about to delete {_carCollection[i-1]} are you absolutely totaly fully completely and without any sign of a last one percent of hesitation SURE you want to delete it ?");
                        Console.WriteLine($"\n yes                           no");
                        Console.WriteLine($"\n  {leftCursor}                            {rightCursor}");
                        

                        select3 = Console.ReadKey();

                        if(select3.Key == ConsoleKey.LeftArrow)
                        {
                            leftCursor = ".";
                            rightCursor = " ";
                        }
                        if(select3.Key == ConsoleKey.RightArrow)
                        {
                            leftCursor = " ";
                            rightCursor = ".";
                        }
                        Console.Clear();
                    }while(select3.Key != ConsoleKey.Enter);

                    if(leftCursor == ".")
                    {
                        Console.WriteLine("that's done ! the car is no longuer available ! you can return to menu ^^\n (enter)");

                        for(int j = i-1; j+1 < _carCollection.Length; j++)
                        {
                            _carCollection[j] = _carCollection[j+1];
                        }
                        _carCollection[_carCollection.Length - 1] = null;
                    }
                    if(rightCursor == ".")
                    {
                        Console.WriteLine("understood, the car will not be deleted, you can return to menu ^^\n (enter)");
                    }

                    break;
                }
                else if(i == _carCollection.Length)
                {
                    Console.WriteLine("sorry, i didn't found your car, actually, my name is rodriguo and i can't found your car, you realize ??? did you understood what mean a LIST ? that mean your first car is the FIRST so you will write 1 ! so don't write 1023994, -1938 or any stupid thing !");
                    Thread.Sleep(15000);
                    Console.WriteLine("...");
                    Thread.Sleep(2000);
                    Console.WriteLine("well excuse me, actually, computers have feelings too ! some time it's hard to serve people who wrote any bul...well forget about that, continue to keep your parking right ? that's great !, now please agree to choose again your car to delete :\n (enter)");
                }
            }


            ConsoleKeyInfo pass;
            do
            {
                pass = Console.ReadKey();
            }while(pass.Key != ConsoleKey.Enter);

            return _carCollection;
        }


        public int HowManyLeftPlaces()
        {
            int numberOfLeft = 0;

            for(int i = 0; i < _carCollection.Length; i++)
            {
                if(_carCollection[i] == null)
                {
                    numberOfLeft ++;
                }
            }
            return numberOfLeft;
        }






        public override string ToString()
        {
            string carCollectionString = "";

            for(int i = 0; i < _carCollection.Length; i++)
            {
                carCollectionString += "\n     " + _carCollection[i];
            }

            return carCollectionString;
        }

    }
}