using System;

namespace exo_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");

            Rectangle suzane = new Rectangle(20,30,15,20);

            Console.WriteLine($"vous regardez le rectangle {nameof(suzane)} : \n{suzane} \naire : {suzane.Aire()}");
            
            Console.Read();
        }
    }
}
