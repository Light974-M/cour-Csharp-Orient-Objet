using System;

namespace exo1
{
    class Program
    {
        public unsafe static void Main(string[] args)
        {
            int myValue = 6;

            int* myValuePointer = &myValue;

            int[] myTabValues = { 36, 4, 90 };

            myValue = myTabValues[1];

            fixed (int* myTabValuePointer = &myTabValues[0])
            {
                Console.WriteLine($"{nameof(myTabValuePointer)} : {*myTabValuePointer}");
                Console.WriteLine($"{nameof(myTabValuePointer)} : {(long)myTabValuePointer}");
                *myTabValuePointer = 780;

                Console.WriteLine($"{nameof(myTabValuePointer)} : {*myTabValuePointer}");
                Console.WriteLine($"{nameof(myValuePointer)} : {*myValuePointer}");
                Console.WriteLine($"{nameof(myValuePointer)} : {(long)myValuePointer}");

                *myValuePointer = 18;
                Console.WriteLine($"{nameof(myValuePointer)} : {*myValuePointer}");

                UneFonctionAuPif(myValuePointer, myTabValuePointer);
                Console.WriteLine($"{nameof(myValue)} : {myValue} et {myTabValues[0]}");
            }




        }

        unsafe static void UneFonctionAuPif(int* pointeur1, int* pointeur2)
        {
            *pointeur2 = *pointeur1;
        }
    }
}
