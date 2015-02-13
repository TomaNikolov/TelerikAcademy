
//Problem 3. Min, Max, Sum and Average of N Numbers

//    Write a program that reads from the console a sequence of n integer 
//numbers and returns the minimal, the maximal number, the sum and the average
//of all numbers (displayed with 2 digits after the decimal point).
//    The input starts by the number n (alone in a line) followed by n lines,
//each holding an integer number.
//    The output is like in the examples below

using System;


    class MinMaxSumAndAverageOfNNumbers
    {
        static void Main()
        {
             Console.Write("Enter N: ");

            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            int sum = 0;
            

            for (int i = 0; i < n; i++)
            {
                Console.Write(": ");
                 numbers[i] = int.Parse(Console.ReadLine());
               
            }
            int min = numbers[0];
            int max = numbers[0];
            for (int i = 0; i < n; i++)
            {
                if(min > numbers[i])
                {
                    min = numbers[i];
                }
                if (max < numbers[i])
                {
                    max = numbers[i];
                }
                sum += numbers[i];
            }
            double avg = (double)sum / n;
            Console.WriteLine("min = {0}", min);
            Console.WriteLine("max = {0}", max);
            Console.WriteLine("sum = {0}", sum);
            Console.WriteLine("avg = {0}", avg.ToString("F2"));
        }
    }

