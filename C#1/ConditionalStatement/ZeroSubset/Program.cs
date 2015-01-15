

    //We are given 5 integer numbers. Write a program that finds all subsets of
    //these numbers whose sum is 0.
    //Assume that repeating the same subset several times is not a problem.


using System;
using System.Collections.Generic;

namespace ZeroSubset
{
    class Program
    {
        static void Main()
        {
            int[] numbers = new int[5];
            int count = 0;
            Console.WriteLine("Enter five numbers: ");
            for (int i = 0; i < 5; i++)
            {
              numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 1; i <= 25; i++)
            {
                int sum = 0;
                List<int> result = new List<int>();
                for (int j = 0; j < 5; j++)
                {
                    

                    int mask = 1 << j;
                    int numberAndMask = i & mask;
                    int bit = numberAndMask >> j;
                    if (bit == 1)
                    {
                        sum += numbers[j];
                        result.Add(numbers[j]);
                    }
                }
                    if (sum == 0)
                    {
                        count++;
                        for (int k = 0; k < result.Count; k++)
                        {
                            if (k == result.Count - 1)
                            {
                                Console.Write(result[k]);
                            }
                            else
                            {
                                Console.Write(" " + result[k] + " " + "+");
                            }
                        }
                            Console.WriteLine(" = 0");
                    }
                        
                    
                
            }
            if(count == 0)
            {
                Console.WriteLine("no zero subset");
            }
            
        }
    }
}
