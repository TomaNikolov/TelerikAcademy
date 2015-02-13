
//Problem 10. Fibonacci Numbers

//    Write a program that reads a number n and prints on the console the first n members of the
//    Fibonacci sequence (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 

using System;

    class FibonaccNumbers
    {
        static void Main()
        {
            Console.Write("Enter  n > 0: ");
            int n = int.Parse(Console.ReadLine());

            int[] fibonacciNumbers = new int[n];
            fibonacciNumbers[0] = 0;
            if (n > 1)
            {
                fibonacciNumbers[1] = 1;
            }

            for (int i = 2; i < n; i++)
            {
                fibonacciNumbers[i] = fibonacciNumbers[i - 1] + fibonacciNumbers[i - 2];
            }

            for (int i = 0; i < n; i++)
            {
                if (i == n - 1)
                {
                    Console.Write(fibonacciNumbers[i]);
                }
                else
                {
                    Console.Write(fibonacciNumbers[i] + ", ");
                }

            }
            Console.WriteLine();
        }
    }

