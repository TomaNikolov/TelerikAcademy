
//Problem 4. Binary search

//    Write a program, that reads from the console an array
//    of N integers and an integer K, sorts the array and 
//    using the method Array.BinSearch() finds the largest 
//    number in the array which is ≤ K.


using System;

class BinarySearch
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter K: ");
        int k = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        Random randomGenerator = new Random();

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = randomGenerator.Next(1, n + 1);
        }
        Array.Sort(arr);
        int index = Array.BinarySearch(arr, k);

        if (index >= 0)
        {
            Console.WriteLine("Equal, on position {0}. ", index);
            Console.WriteLine(string.Join(", ", arr));
        }
        else
        {
            index = Math.Abs(index) - 2;
            if (index >= 0)
            {
                Console.WriteLine("Less, on position {0}. ", index);
                Console.WriteLine(string.Join(", ", arr));
            }
            else
            {
                Console.WriteLine("No number less or equal to {0} found.", k);
            }
        }

    }
}

