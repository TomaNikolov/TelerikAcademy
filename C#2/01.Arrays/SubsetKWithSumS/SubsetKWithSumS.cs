
//Problem 17.* Subset K with sum S

//    Write a program that reads three integer numbers N, K and S 
//    and an array of N elements from the console.
//    Find in the array a subset of K elements that have sum S or
//    indicate about its absence.

using System;
using System.Linq;
using System.Text;

class SubsetKWithSumS
{
    static void Main()
    {
        Console.Write("Enter S: ");
        int s = int.Parse(Console.ReadLine());
        Console.Write("Enter K: ");
        int k = int.Parse(Console.ReadLine());
        Console.Write("Enter array: ");
        string inputNumbers = Console.ReadLine();

        int[] arr = (from x in inputNumbers.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                     select int.Parse(x)).ToArray();
        int MaxSubset = (int)Math.Pow(2, arr.Length);
        bool isExist = false;

        for (int i = 1; i < MaxSubset; i++)
        {
            int checkingSum = 0;
            int couner = 0;
            StringBuilder subSet = new StringBuilder();
            for (int j = 0; j <= arr.Length; j++)
            {
                int mask = 1 << j;
                int nAndMask = i & mask;
                int bit = nAndMask >> j;
                if (bit == 1)
                {
                    checkingSum = checkingSum + arr[j];
                    couner++;
                    subSet.AppendFormat("{0}, ", arr[j]);
                }
            }
            if (checkingSum == s && couner == k)
            {
                Console.WriteLine("Yes");
                Console.WriteLine(subSet.ToString());
                isExist = true;
                return;
            }
            subSet.Clear();
        }
        if (!isExist)
        {
            Console.WriteLine("No");
        }
    }

}


