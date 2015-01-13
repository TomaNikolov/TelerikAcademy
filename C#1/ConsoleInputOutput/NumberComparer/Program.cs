using System;

namespace NumberComparer
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter  a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Enter  b: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("The greater is {0}.", (a > b) ? a : b);
        }
    }
}
