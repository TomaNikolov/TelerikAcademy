
//Problem 1. Sum of 3 Numbers

//    Write a program that reads 3 real numbers from the console and prints their sum.


using System;

    class SumOfThreeNumbers
    {
        static void Main()
        {
            Console.Write("Enter a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Enter b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Enter c: ");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine("Sum of a, b and c is {0}.", (a + b + c));
        }
    }

