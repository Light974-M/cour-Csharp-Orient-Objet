using System;

namespace cour2
{
    class Program
    {
        public unsafe static void Main(string[] args)
        {

            int v1 = 1;
            int* P1 = &v1;

            pointerPoint ->x = 12;
            pointerPoint ->y = 42;
            Console.WriteLine($"Value {nameof(pointerPoint)} : {pointerPoint ->y}");

            
        }
    }
}
