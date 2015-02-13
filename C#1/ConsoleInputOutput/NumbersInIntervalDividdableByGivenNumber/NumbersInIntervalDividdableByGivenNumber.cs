
//Problem 11.* Numbers in Interval Dividable by Given Number

//    Write a program that reads two positive integer numbers and prints how many numbers p exist 
//between them such that the reminder of the division by 5 is 0.


using System;
using System.Collections.Generic;

    class NumbersInIntervalDividdableByGivenNumber
    {
        static void Main()
        {

            Console.Write("Enter  start number: ");
            int startNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter  end number: ");
            int endNumber = int.Parse(Console.ReadLine());
            int result = 0;

           // List<int> numbers = new List<int>();

            for (int i = startNumber; i <= endNumber; i++)
            {
                if (i % 5 == 0)
                {
                  //  numbers.Add(i);
                    result++;
                }
            }
            // Uncomment if you want to see the numbers divisible by 5

            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    Console.Write(numbers[i]);
            //    if(i != numbers.Count -1)
            //    {
            //        Console.Write(", ");
            //    }
            //    else
            //    {
            //        Console.WriteLine();
            //    }
            //}

            Console.WriteLine(result);
        }
    }

