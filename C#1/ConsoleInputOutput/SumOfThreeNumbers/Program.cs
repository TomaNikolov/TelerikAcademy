using System;

namespace SumOfThreeNumbers
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Enter b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Enter c: ");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine("Sum of a, b and c is {0}.", (a + b + c));
        }
    }
}
