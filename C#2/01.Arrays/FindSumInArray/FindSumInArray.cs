
//Problem 10. Find sum in array

//    Write a program that finds in given array of integers a sequence of given sum S (if present).


using System;
using System.Text;

    class FindSumInArray
    {
        static void Main()
        {
            int[] arr = { 4, 3, 1, 4, 2, 5, 8 };
           
            StringBuilder sequence = new StringBuilder();
            int sum = 11;

            for (int i = 0; i < arr.Length; i++)
            {
                int currentSum = 0;
                for (int j = i; j < arr.Length; j++)
                {
                    currentSum += arr[j];
                    sequence.AppendFormat("{0}, ", arr[j]);
                    if(currentSum == sum)
                    {
                        Console.WriteLine("The sequence with sum {0} is: {1}", sum, sequence);
                        return;
                    }
                }
                sequence.Clear();
            }
            Console.WriteLine("There is no that kind of sequence.");
        }
    }

