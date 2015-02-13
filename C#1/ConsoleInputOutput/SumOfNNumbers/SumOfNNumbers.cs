
//Problem 9. Sum of n Numbers

//    Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note: You may need to use a for-loop.


using System;

    class SumOfNNumbers
    {
        static void Main()
        {
            Console.Write("Enter  n: ");
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter a number: ");
                sum += double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Sum is {0}", sum);
        }
    }
