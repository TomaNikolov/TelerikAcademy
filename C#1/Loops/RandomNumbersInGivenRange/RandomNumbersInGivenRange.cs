
//Problem 11. Random Numbers in Given Range

//    Write a program that enters 3 integers n, min and max (min = max)
//and prints n random numbers in the range [min...max].


using System;
using System.Collections.Generic;


class RandomNumbersInGivenRange
{
    static void Main(string[] args)
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter Min: ");
        int Min = int.Parse(Console.ReadLine());
        Console.Write("Enter Max: ");
        int Max = int.Parse(Console.ReadLine());
        Random randomGenerator = new Random();
        List<int> listOfNumbers = new List<int>();

        for (int i = Min; i <= Max; i++)
        {
            listOfNumbers.Add(i);
        }
        for (int i = 0; i < n; i++)
        {
            Console.Write(listOfNumbers[randomGenerator.Next(0, ((Max - Min) + 1))] + " ");
        }
    }
}

