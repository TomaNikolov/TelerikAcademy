
//Problem 9. Matrix of Numbers

//    Write a program that reads from the console a positive integer
//number n (1 = n = 20) and prints a matrix like in the examples below. 
//Use two nested loops.


using System;


    class MatrixOfNumbers
    {
        static void Main()
        {
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < n; i++)
            {

                for (int j = 1; j <= n; j++)
                {
                    Console.Write((j + count) + " ");
                }
                count++;
                Console.WriteLine();
            }
        }
    }

