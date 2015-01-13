using System;

namespace PointInaCircle
{
    class Program
    {
        static void Main()
        {
            double x;
            double y;

            Console.Write("Enter X: ");

            x = double.Parse(Console.ReadLine());

            Console.Write("Enter Y: ");

            y = double.Parse(Console.ReadLine());

            if (IsInside(x, y))
            {
                Console.WriteLine("Point is inside a circle.");
            }
            else
            {
                Console.WriteLine("Point is not inside a circle.");
            }
        }
        public static bool IsInside(double x, double y)
        {
            double distance = Math.Sqrt(Math.Pow((0 - x), 2) + Math.Pow((0 - y), 2));

            if (distance <= 2)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
