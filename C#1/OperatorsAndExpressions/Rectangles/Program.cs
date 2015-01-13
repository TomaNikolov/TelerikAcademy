using System;

namespace Rectangles
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Enter height: ");
            double height = double.Parse(Console.ReadLine());

            double area = width * height;
            double perimeter = (width + height) * 2;

            Console.WriteLine("Area is {0}.", area);
            Console.WriteLine("Perimeter is {0}.", perimeter);
        }
    }
}
