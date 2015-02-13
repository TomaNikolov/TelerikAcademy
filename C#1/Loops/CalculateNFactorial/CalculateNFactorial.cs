
//Problem 7. Calculate N! / (K! * (N-K)!)

//    In combinatorics, the number of ways to choose k different members out of
//a group of n different elements (also known as the number of combinations)
//is calculated by the following formula: formula For example, there are 
//2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
//    Your task is to write a program that calculates n! / (k! * (n-k)!)
//for given n and k (1 < k < n < 100). Try to use only two loops.


using System;
using System.Numerics;


class CalculateNFactorial
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter K: ");
        int k = int.Parse(Console.ReadLine());

        BigInteger result = (GetFactorial(n)) / (GetFactorial(k) * GetFactorial(n - k));
        Console.WriteLine(result);

    }

    private static BigInteger GetFactorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        return n * GetFactorial(n - 1);
    }
}


