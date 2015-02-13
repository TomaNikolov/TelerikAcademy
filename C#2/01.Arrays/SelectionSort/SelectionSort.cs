
//Problem 7. Selection sort

//    Sorting an array means to arrange its elements in increasing order. 
//    Write a program to sort an array.
//    Use the Selection sort algorithm: Find the smallest element, 
//    move it at the first position, find the smallest from the rest,
//    move it at the second position, etc.


using System;

    class SelectionSort
    {
        static void Main()
        {
            Console.WriteLine("Array is:  2, 3, -6, -1, 2, -1, 6, 4, -8, 8 ");
            int[] arr = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
            

            for (int i = 0; i < arr.Length - 1; i++)
            {
               int min = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if(arr[j] < arr[min])
                    {
                        min = j;
                    }
                }
                if(min != i )
                {
                    Swap(min, i, arr);  
                }
            }
            Console.Write("Sorted : ");
            for (int i = 0; i < arr.Length; i++)
            {
                 Console.Write(arr[i]);
                if(i != arr.Length -1)
                {
                    Console.Write(", ");
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }

        public static void Swap(int position1, int position2, int[] arr)
        {
            int temp = arr[position1];
            arr[position1] = arr[position2];
            arr[position2] = temp;
        }
    }

