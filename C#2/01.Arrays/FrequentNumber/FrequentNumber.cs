
//Problem 9. Frequent number

//    Write a program that finds the most frequent number in an array.


using System;
using System.Linq;

class FrequentNumber
{
    static void Main()
    {
        Console.Write("Enter  input: ");
        string inputNumbers = Console.ReadLine();
        int n = inputNumbers.Length;
        int[] arr = (from x in inputNumbers.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                     select int.Parse(x)).ToArray();
        int digit = 0;
        int frequentNumber = 0;


        for (int i = 0; i < 9; i++)
        {
            int counter = 0;
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                {
                    counter++;
                }

                if (counter > frequentNumber)
                {
                    frequentNumber = counter;
                    digit = arr[i];
                }
            }
        }
        Console.WriteLine("{0}({1} times)", digit, frequentNumber);
    }

}


