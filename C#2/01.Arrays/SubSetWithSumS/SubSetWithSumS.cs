using System;
using System.Linq;


class SubSetWithSumS
{
    static void Main()
    {
        Console.Write("Enter S: ");
        int s = int.Parse(Console.ReadLine());
        Console.Write("Enter array: ");
        string inputNumbers = Console.ReadLine();
        int[] arr = (from x in inputNumbers.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                     select int.Parse(x)).ToArray();
        int MaxSubset = (int)Math.Pow(2, arr.Length);
        bool isExist = false;

        for (int i = 1; i < MaxSubset; i++)
        {
            int checkingSum = 0;
           
            for (int j = 0; j <= arr.Length; j++)
            {
                int mask = 1 << j;
                int nAndMask = i & mask;
                int bit = nAndMask >> j;
                if (bit == 1)
                {
                    checkingSum = checkingSum + arr[j];
                  
                }
            }
            if (checkingSum == s)
            {
                Console.WriteLine("Yes");
                isExist = true;
                return;
            }
        }
        if(!isExist)
        {
            Console.WriteLine("No");
        }
    }

}


