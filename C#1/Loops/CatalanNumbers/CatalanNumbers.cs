
//Problem 8. Catalan Numbers

//    In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
//    Write a program to calculate the nth Catalan number by given n (1 < n < 100).


using System;
using System.Numerics;


    class CatalanNumbers
    {
        static void Main()
        {
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            BigInteger result = GetFactorial(2 * n) / (GetFactorial(n + 1) * GetFactorial(n));

            Console.WriteLine(result);
        }

        private static BigInteger GetFactorial(int n)
        {
         if(n == 0)
         {
             return 1;
         }
         return n * GetFactorial(n - 1);
        }
    }

