
//Problem 6. Sum integers

//    You are given a sequence of positive integer values written
//    into a string, separated by spaces.
//    Write a function that reads these values from given
//    string and calculates their sum.


using System;
using System.Linq;

class Workdays
{
    static void Main()
    {
        Console.WriteLine("Entrer numbers separated by spaces:");
        Console.Write(">> ");
        int[] arr = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        Console.WriteLine("Sum is {0}", sum);

    }
}

