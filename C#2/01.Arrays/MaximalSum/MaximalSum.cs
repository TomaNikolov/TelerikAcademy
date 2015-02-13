
//Problem 8. Maximal sum

//    Write a program that finds the sequence of maximal sum in given array.


using System;
using System.Text;

class MaximalSum
{
    static void Main()
    {
       
        int[] arr = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
        int maxSum = int.MinValue;
        StringBuilder sequence = new StringBuilder();
        int sum = 0;
        string resultSequence = "";

        for (int i = 1; i < arr.Length; i++)
        {
            sum += arr[i];
            sequence.AppendFormat("{0}, ", arr[i]);
            if (sum > maxSum)
            {
                resultSequence = sequence.ToString();
                maxSum = sum;
            }
            if (sum < 0)
            {
                sequence.Clear();
                sum = 0;
            }
        }

        Console.WriteLine("Sequence is: " + resultSequence);
        Console.WriteLine("Maximal sum is: " + sum);
    }
}



