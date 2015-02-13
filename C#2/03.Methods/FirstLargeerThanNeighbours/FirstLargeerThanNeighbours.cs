
//Problem 6. First larger than neighbours

//    Write a method that returns the index of the first element
//    in array that is larger than its neighbours, or -1, if there’s no such element.
//    Use the method from the previous exercise.


using System;

class FirstLargeerThanNeighbours
{
    static void Main()
    {

        int[] arr = new int[9]{
        1, 2, 1, 4, 3, 6, 4, 8, 7
        };
        int index = NeighboursCheck(arr);
        if(index >= 0)
        {
            Console.WriteLine("First element larger than neighbour is on position {0}.", index);
        }
        else
        {
            Console.WriteLine("No such element.");
        }
        Console.Write("Array is: ");
        Console.WriteLine(string.Join(", ", arr));
       
    }

    private static int NeighboursCheck(int[] arr)
    {
        int index = int.MinValue;
        for (int position = 1; position < arr.Length - 1; position++)
        {
            if(arr[position] > arr[position + 1] && arr[position] > arr[position - 1])
            {
                index = position;
                break;
            }
        }
        if(index >= 0)
        {
            return index;
        }
        else
        {
            return -1;
        }
    }
}

