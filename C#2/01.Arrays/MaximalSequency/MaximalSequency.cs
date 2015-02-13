
//Problem 4. Maximal sequence

//    Write a program that finds the maximal sequence of equal elements in an array.


using System;
using System.Linq;

class MaximalSequency
{
    static void Main()
    {
        Console.Write("Enter  array: ");
        string inputNumbers = Console.ReadLine();
        int n = inputNumbers.Length;
        //Linq expression. See https://code.msdn.microsoft.com/101-LINQ-Samples-3fb9811b
        int[] arr = (from x in inputNumbers.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                     select int.Parse(x)).ToArray();
        int digit = 0;
        int maxNumberCounter = 0;
        int counter = 1;

        for (int i = 1; i < arr.Length; i++)
        {


            if (arr[i] == arr[i - 1])
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
            Console.Write(digit);
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

