using System;

namespace exo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            MyStruct varMyStruct1;
            varMyStruct1.index = 1;

            MyStruct varMyStruct2 = new MyStruct();
            varMyStruct1 = varMyStruct2;
            varMyStruct1.index = 10;
            varMyStruct2.index = 3;

            Console.WriteLine($"{nameof(varMyStruct1)} : {varMyStruct1.index} et {nameof(varMyStruct1)} : {varMyStruct1.index}");

            MyClass varMyClass1;

            MyClass varMyClass2 = new MyClass();

            varMyClass1 = varMyClass2;
            varMyClass1.index = 1;
            varMyClass2.index = 5;

            Console.WriteLine($"{nameof(varMyClass1)} : {varMyClass1.index} et {nameof(varMyClass1)} : {varMyClass1.index}");
        }
    }
}
