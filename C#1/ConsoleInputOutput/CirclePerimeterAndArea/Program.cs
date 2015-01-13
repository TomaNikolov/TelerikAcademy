using System;
using System.Globalization;

namespace CirclePerimeterAndArea
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter radius r: ");
            double radius = double.Parse(Console.ReadLine());

            double perimeter = 2 * Math.PI * radius;
            double area = Math.PI * (radius * radius);

            Console.WriteLine("Perimeter is {0}", perimeter.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Area is {0}", area.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
