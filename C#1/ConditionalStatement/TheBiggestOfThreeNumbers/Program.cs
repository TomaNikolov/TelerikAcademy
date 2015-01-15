
//Write a program that finds the biggest of three numbers.

using System;

namespace TheBiggestOfThreeNumbers
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
           
            if( BigestNumber(a, b) > c )
            {
                Console.WriteLine(BigestNumber(a, b));
            }
            else
            {
                Console.WriteLine(c);
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
