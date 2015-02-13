
//Problem 6. Maximal K sum

//    Write a program that reads two integer numbers N and K and an array of N elements from the console.
//    Find in the array those K elements that have maximal sum.


using System;
using System.Linq;

    class MaximalKSum
    {
        static void Main()
        {
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter K: ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("Enter array: ");
            string inputNumbers = Console.ReadLine();
            //Linq expression. See https://code.msdn.microsoft.com/101-LINQ-Samples-3fb9811b
            int[] arr = (from x in inputNumbers.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                         select int.Parse(x)).ToArray();
            int firstElementOfSequency = 0;
            int maxSum = 0;
           

            for (int i = 0; i <= n - k; i++)
            {
                int sum = 0;

                for (int j = i; j < i + k; j++)
                {
                    sum += arr[j];
                }
                if(maxSum < sum)
                {
                    maxSum = sum;
                    firstElementOfSequency = i;
                }
            }
            for (int i = firstElementOfSequency; i < firstElementOfSequency + k ; i++)
            {
                Console.Write(arr[i]);
                if(i != (firstElementOfSequency + k) -1)
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

