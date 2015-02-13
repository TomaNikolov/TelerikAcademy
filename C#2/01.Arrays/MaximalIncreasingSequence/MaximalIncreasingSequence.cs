
//Problem 5. Maximal increasing sequence

//    Write a program that finds the maximal increasing sequence in an array.

using System;
using System.Linq;

class MaximalIncreasingSequence
{
    static void Main()
    {
        Console.Write("Enter  input: ");
        string inputNumbers = Console.ReadLine();
        int[] arr = (from x in inputNumbers.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                     select int.Parse(x)).ToArray();
        int digit = 0;
        int maxNumberCounter = 0;
        int counter = 1;

        for (int i = 1; i < arr.Length; i++)
        {


            if (arr[i] - arr[i - 1] == 1)
            {
                counter++;
            }
            else
            {
                counter = 1;
            }

            if (counter > maxNumberCounter)
            {
                maxNumberCounter = counter;
                digit = arr[i];
            }
        }
        for (int i = 0; i < maxNumberCounter; i++)
        {
            Console.Write((digit - (maxNumberCounter - 1)) + i);
            if (i != maxNumberCounter - 1)
            {
                Console.Write(", ");
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}


