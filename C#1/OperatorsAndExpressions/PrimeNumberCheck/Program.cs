using System;

namespace PrimeNumberCheck
{
    class Program
    {
        static void Main()
        {

            Console.Write("Enter Number: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("The number {0} is {1}prime.", n, isPrime(n) ? "" : "not ");
        }

        private static bool isPrime(int n)
        {
            if (n < 2 && n == 3)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return true;
                }

            }
            return false;
        }

    }
}
