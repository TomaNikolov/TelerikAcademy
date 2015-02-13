
//Problem 15. Prime numbers

//    Write a program that finds all prime numbers in the range [1...10 000 000]. 
//Use the Sieve of Eratosthenes algorithm.


using System;
using System.Text;

class Program
{
    static void Main()
    {
        int n = 10 000 000;
        bool[] isPrime = new bool[n + 1];
        StringBuilder primeNumbers = new StringBuilder();
        for (int i = 2; i <= n; i++)
        {
            if (isPrime[i] == false)
            {
                if (i < Math.Sqrt(isPrime.Length))
                {
                    for (int j = i * i; j <= n; j += i)
                    {
                        isPrime[j] = true;
                    }
                }
                primeNumbers.AppendFormat("{0}, ", i);
            }
        }
        Console.WriteLine(primeNumbers.ToString());
    }
}

