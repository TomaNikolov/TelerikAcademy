
//Write a program that finds the biggest of five numbers by using only five if statements.

using System;

namespace TheBigestOfFiveNumbers
{
    class Program
    {
        static void Main()
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("d = ");
            double d = double.Parse(Console.ReadLine());
            Console.Write("e = ");
            double e = double.Parse(Console.ReadLine());

            if (BigestNumber(a, b) > BigestNumber(c, d))
            {
                if (BigestNumber(a, b) > e)
                {
                    Console.WriteLine(BigestNumber(a, b));
                }
                else
                {
                    Console.WriteLine(e);
                }
            }
            else
            {
                if (BigestNumber(c, d) > e)
                {
                    Console.WriteLine(BigestNumber(c, d));
                }
                else
                {
                    Console.WriteLine(e);
                }
            }
        }

        private static double BigestNumber(double a, double b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}
