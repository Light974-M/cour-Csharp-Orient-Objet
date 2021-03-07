using System;

namespace Exo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(4.5);
            Square square1 = new Square(6);
            Rectangle rectangle1 = new Rectangle(3.5, 6.2);

            Console.WriteLine($"circle1 : {circle1} \nsquare1 : {square1} \nrectangle : {rectangle1}");
        }
    }
}
