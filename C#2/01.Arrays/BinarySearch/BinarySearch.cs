
//Problem 11. Binary search

//    Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.


using System;
using System.Linq;

    class BinarySearch
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 3, 1, 4, 2, 5, 8 };
            int key = 4;
            Array.Sort(arr);
            Console.Write("Sorted array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                
                if(i == arr.Length -1)
                {
                    Console.WriteLine("");
                }
                else
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("Key: " + key);
            int indexOfK = BinarySearchIndex(arr, key, 0, arr.Length - 1);
            Console.WriteLine("Index: " + indexOfK);
        }

        private static int BinarySearchIndex(int[] arr, int key, int min, int max)
        {
           if(max < min)
           {
               return -1;
           }
           else
           {
               int mid = ((max - min) / 2 ) + min;
               if(arr[mid] > key)
               {
                   return BinarySearchIndex(arr, key, min, mid - 1 );
               }
               else if(arr[mid] < key)
               {
                   return BinarySearchIndex(arr, key, mid + 1, max);
               }
               else
               {
                   return mid;
               }
           }
        }
    }

