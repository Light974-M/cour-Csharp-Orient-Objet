using System;
using System.Threading;

namespace DM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.Clear();

            Console.WriteLine("Hello !");
            Thread.Sleep(1000);
            Console.WriteLine("Bonjour !");
            Thread.Sleep(1000);
            Console.WriteLine("Buongiorno !");
            Thread.Sleep(1000);
            Console.WriteLine("¡ Hola !");
            Thread.Sleep(1000);
            Console.WriteLine("¡ Olá !");
            Thread.Sleep(1000);
            Console.WriteLine("Guten tag !");
            Thread.Sleep(1000);
            Console.WriteLine("Hallo !");
            Thread.Sleep(2000);
            Console.WriteLine("hi, I am Rodriguo, your virtual assistant that will help you to build and keep going every parking you want in your parking gestion !\n (enter)");
            PressEnter();
            Console.WriteLine("in order to begin, we will do together your first parking, incredible isn't it ?\n (enter)");
            PressEnter();
            Console.WriteLine("you need a first parking to create new cars, so, let's do it !\n (enter)");
            PressEnter();







            bool isInteger = false;
            string collectionSize = "0";

            while (!isInteger)
            {
                isInteger = true;
                Console.WriteLine("please choose the size of your first parking : ");
                collectionSize = Console.ReadLine();

                if (string.IsNullOrEmpty(collectionSize))
                {
                    Console.WriteLine($"Error n°2 : the collection can't be unnamed, please enter a name and retry.");
                    isInteger = false;
                }

                for (int i = 0; i < collectionSize.Length; i++)
                {
                    if (collectionSize[i] != '0' && collectionSize[i] != '1' && collectionSize[i] != '2' && collectionSize[i] != '3' && collectionSize[i] != '4' && collectionSize[i] != '5' && collectionSize[i] != '6' && collectionSize[i] != '7' && collectionSize[i] != '8' && collectionSize[i] != '9')
                    {
                        Console.WriteLine("error n°1 : the character you have entered is not an integer, please do not write letters, specials characters, or decimal numbers, and retry.");
                        isInteger = false;
                        break;
                    }
                    if (collectionSize[i] == '0')
                    {
                        Console.WriteLine("error n°4 : the character you have entered is null, and a parking without places simply not exist, please agree to retry :");
                        isInteger = false;
                        break;
                    }
                }
            }

            int collectionIntSize = Convert.ToInt32(collectionSize);

            Cars[] carCollection = new Cars[collectionIntSize];

            Parking parking1 = new Parking(carCollection, 13, 0);

            Console.WriteLine("farewell ! you are now ready to go on your own cowboy !\n (enter)");
            PressEnter();
            Console.Clear();
            bool mainLoop = true;
            string leftSelector = "__";
            string rightSelector = "  ";
            string topSelector = " ";
            string bottomSelector = " ";

            string secondLeftSelector = "__";
            string secondTopSelector = " ";
            string secondRightSelector = "  ";

            while (mainLoop)
            {
                ConsoleKeyInfo select;
                do
                {
                    Console.WriteLine($"press enter :                                    -create new car                                                                 ");
                    Console.WriteLine($"                                                                                                                                 ");
                    Console.WriteLine($"                                                        {topSelector}                                                            ");
                    Console.WriteLine($"                                                                                                                                 ");
                    Console.WriteLine($"                                                                                                                                 ");
                    Console.WriteLine($"            -create new ticket          {leftSelector}                             {rightSelector}          -modify tickets      ");
                    Console.WriteLine($"                                                                                                                                 ");
                    Console.WriteLine($"                                                                                                                                 ");
                    Console.WriteLine($"                                                        {bottomSelector}                                                         ");
                    Console.WriteLine($"                                                                                                                                 ");
                    Console.WriteLine($"                                                  -modify a car                                                                  ");
                    Console.WriteLine($"{nameof(parking1)} :                                                                                                             ");
                    Console.WriteLine($"                 -collection : {parking1}                                                                                        ");
                    Console.WriteLine($"                                                                                                                                 ");




                    select = Console.ReadKey();
                    if (select.Key == ConsoleKey.LeftArrow)
                    {
                        leftSelector = "__";
                        rightSelector = "  ";
                        topSelector = " ";
                        bottomSelector = " ";
                    }
                    if (select.Key == ConsoleKey.RightArrow)
                    {
                        leftSelector = "  ";
                        rightSelector = "__";
                        topSelector = " ";
                        bottomSelector = " ";
                    }
                    if (select.Key == ConsoleKey.UpArrow)
                    {
                        leftSelector = "  ";
                        rightSelector = "  ";
                        topSelector = "|";
                        bottomSelector = " ";
                    }
                    if (select.Key == ConsoleKey.DownArrow)
                    {
                        leftSelector = "  ";
                        rightSelector = "  ";
                        topSelector = " ";
                        bottomSelector = "|";
                    }
                    Console.Clear();
                } while (select.Key != ConsoleKey.Enter);

                if (topSelector == "|")
                {
                    carCollection = parking1.AddCar();
                    Console.Clear();
                }

                if (bottomSelector == "|")
                {
                    ConsoleKeyInfo select2;
                    do
                    {

                        Console.WriteLine($"escape                                           -delete car                                                                     ");
                        Console.WriteLine($"                                                                                                                                 ");
                        Console.WriteLine($"                                                        {secondTopSelector}                                                            ");
                        Console.WriteLine($"                                                                                                                                 ");
                        Console.WriteLine($"                                                                                                                                 ");
                        Console.WriteLine($"            -change car's owner          {secondLeftSelector}                  {secondRightSelector}          -how many place left ?                          ");
                        Console.WriteLine($"                                                                                                                                 ");
                        Console.WriteLine($"                                                                                                                                 ");
                        Console.WriteLine($"                                                                                                                                 ");
                        Console.WriteLine($"                                                                                                                                 ");
                        Console.WriteLine($"                                                                                                                                 ");


                        select2 = Console.ReadKey();
                        if (select2.Key == ConsoleKey.LeftArrow)
                        {
                            secondLeftSelector = "__";
                            secondTopSelector = " ";
                            secondRightSelector = "  ";
                        }
                        if (select2.Key == ConsoleKey.UpArrow)
                        {
                            secondLeftSelector = "  ";
                            secondTopSelector = "|";
                            secondRightSelector = "  ";
                        }
                        if (select2.Key == ConsoleKey.RightArrow)
                        {
                            secondLeftSelector = "  ";
                            secondTopSelector = " ";
                            secondRightSelector = "__";
                        }
                        Console.Clear();
                    } while (select2.Key != ConsoleKey.Enter && select2.Key != ConsoleKey.Escape);

                    if (select2.Key != ConsoleKey.Escape)
                    {
                        if (secondTopSelector == "|")
                        {
                            Console.Clear();
                            Console.WriteLine("so, you have choosen to delete a car ? select the car you want his owner to leave with by writting his position in list(if you don't select, no car will be deleted) : ");
                            Console.WriteLine(parking1);
                            carCollection = parking1.DeleteCar();
                        }
                        if (secondRightSelector == "__")
                        {
                            Console.WriteLine($"you still have {parking1.HowManyLeftPlaces()} places left, i am coded by indian people so i don't see if it's 0, it is ? \n (enter)");
                            PressEnter();
                            if (parking1.HowManyLeftPlaces() == 0)
                            {
                                Console.WriteLine($"wow ! calm down ! you really trusted me ^^ don't worry, in the case where you don't know 0 means no places, i can tell you that you have 0 places so you have no places left. \n (enter)");
                            }
                            else
                            {
                                Console.WriteLine($"wow ! calm down ! you really trusted me ^^ don't worry, in the case where you don't know 0 means no places, i can tell you that you still have more than 0 places, so you have still places, that's it. \n (enter)");
                            }
                            PressEnter();
                        }
                    }




                    Console.Clear();
                }
            }
        }
        public static void PressEnter()
        {
            ConsoleKeyInfo pass;
            do
            {
                pass = Console.ReadKey();
            } while (pass.Key != ConsoleKey.Enter);
        }
    }
}
