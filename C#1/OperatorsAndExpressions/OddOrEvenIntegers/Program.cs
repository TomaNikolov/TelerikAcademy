using System;

namespace OddOrEvenIntegers
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0 )
            {
                Console.WriteLine("The number {0} is even.", number);
            }
            else
            {
                Console.WriteLine("The number {0} is odd.", number);
            }
        }
    }
}
