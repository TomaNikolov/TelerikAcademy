
//Problem 9. Sorting array

//    Write a method that return the maximal element in a portion 
//    of array of integers starting at given index.
//    Using it write another method that sorts an array in 
//    ascending / descending order.

using System;

class SortingArray
{
    static void Main()
    {
        Console.Write("Enter size of array N: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Enter element {0}: ", i);
            arr[i] = int.Parse(Console.ReadLine()); 
        }
        Console.Write("Enter strat index: ");
        int start = int.Parse(Console.ReadLine());
        Console.Write("Enter end index: ");
        int end = int.Parse(Console.ReadLine());
        int index = GetMaxElement(arr, start, end);
        Console.WriteLine("Maximal element is: {0}", arr[index]);
       // int[] ascendingArray = AscendingSort(arr);
        DescendingSort(arr);
        Console.WriteLine("Descending sort: " +string.Join(", ", arr));
        AscendingSort(arr);
        Console.WriteLine("Ascending sort : " + string.Join(", ", arr));
    }

    private static void DescendingSort(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            int swap = arr[i];
            int max = GetMaxElement(arr, i, arr.Length -1);
            arr[i] = arr[max];
            arr[max] = swap;
        }
    }

    private static void AscendingSort(int[] arr)
    {
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            int swap = arr[i];
            int max = GetMaxElement(arr, 0, i);
            arr[i] = arr[max];
            arr[max] = swap;
        }
    }

    private static int GetMaxElement(int[] arr, int start, int end)
    {
        if (start < 0 || end >= arr.Length)
        {
            throw new Exception("Index Out of range.");
        }
        int max = start;
        for (int i = start; i <  end; i++)
        {
            if(arr[max] < arr[i + 1])
            {
                max = i + 1;
            }
        }
        return max;
    }
}

