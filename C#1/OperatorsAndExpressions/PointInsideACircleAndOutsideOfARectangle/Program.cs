using System;

namespace PointInsideACircleAndOutsideOfARectangle
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

            if (IsInside(x, y) && IsOutside(x, y))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
        public static bool IsInside(double x, double y)
        {
            double distance = Math.Sqrt(Math.Pow((1 - x), 2) + Math.Pow((1 - y), 2));

            if (distance <= 1.5)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static bool IsOutside(double x, double y)
        {
            if ((x <= 5 && x >= -1) && (y >= -1 && y <= 1))
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}

