using System;
using System.Collections.Generic;
using System.Linq;

    class RemoveElementsFromArray
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array: ");
            string inputNumbers = Console.ReadLine();

            int[] arr = (from x in inputNumbers.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                         select int.Parse(x)).ToArray();
            int MaxSubset = (int)Math.Pow(2, arr.Length);
            List<int> result = new List<int>();
            int resultLen = 0;
             

            for (int i = 1; i < MaxSubset; i++)
            {
                int counter = 0;
                List<int> newArr = new List<int>();

                for (int j = 0; j <= arr.Length; j++)
                {
                    int mask = 1 << j;
                    int nAndMask = i & mask;
                    int bit = nAndMask >> j;
                    if (bit == 1)
                    {
                        newArr.Add(arr[j]);
                        counter++;
                    }
                }
                if (ArrayIsSorted(newArr) && counter > resultLen)
                {
                    resultLen = counter;
                    result = newArr;

                }
            }
            Console.WriteLine(string.Join(", ", result));
        }

        private static bool ArrayIsSorted(List<int> newArr)
        {
            bool isSorted = true;

            for (int i = 1; i < newArr.Count; i++)
            {
                if(!(newArr[i - 1] <= newArr[i]))
                {
                    isSorted = false;
                }
            }
            return isSorted;
        }
    }

