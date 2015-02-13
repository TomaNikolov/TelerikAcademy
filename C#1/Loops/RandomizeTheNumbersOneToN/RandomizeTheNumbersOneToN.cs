
//Problem 12.* Randomize the Numbers 1…N

//    Write a program that enters in integer n and prints the numbers
//1, 2, …, n in random order.


using System;
using System.Collections.Generic;


class RandomizeTheNumbersOneToN
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        List<int> numbers = new List<int>();
        Random randomGenerator = new Random();

        for (int i = 1; i <= n; i++)
        {
            numbers.Add(i);
        }
        for (int i = 0; i < n; i++)
        {
            int a = randomGenerator.Next(numbers.Count);
            Console.Write(numbers[a] + " ");
            numbers.Remove(numbers[a]);
        }
        Console.WriteLine();
    }
}

