
//Problem 5. Larger than neighbours

//    Write a method that checks if the element at given 
//    position in given array of integers is larger than its two neighbours (when such exist).


using System;

class LargerThanNeighbours
{
    static void Main()
    {
        int[] arr = new int[9]{
        1, 2, 1, 4, 3, 6, 4, 8, 7
        };
        Console.Write("Enter position of element: ");
        int position = int.Parse(Console.ReadLine());
        if (NeighboursCheck(arr, position))
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
        Console.WriteLine(string.Join(", ", arr));
    }

    private static bool NeighboursCheck(int[] arr, int position)
    {
        if(position > arr.Length - 1 || position < 0)
        {
            return false;
        }
        else if (position == 0 || position == arr.Length - 1)
        {
            return false;
        }
        else if(arr[position] > arr[position + 1] && arr[position] > arr[position - 1])
        {
            return true;
        }
        else
        {
            return false;
        }
       
    }
}

