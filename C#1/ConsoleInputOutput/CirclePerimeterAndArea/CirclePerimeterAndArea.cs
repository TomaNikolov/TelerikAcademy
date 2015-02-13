
//Problem 3. Circle Perimeter and Area

//    Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.


using System;
using System.Globalization;

    class CirclePerimeterAndArea
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

