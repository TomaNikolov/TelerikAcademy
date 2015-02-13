
//Problem 5. Calculate 1 + 1!/X + 2!/X2 + … + N!/XN

//    Write a program that, for a given two integer numbers n and x, 
//calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/xn.
//    Use only one loop. Print the result with 5 digits after the decimal point.


using System;


    class Calculate
    {
        static void Main()
        {
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter X: ");
            double x = double.Parse(Console.ReadLine());

            double sum = 1;
            for (int i = 1; i <= n; i++)
            {
                sum += (double)(GetFactorial(i)) / (double)(Math.Pow(x, i));
            }

            Console.WriteLine("sum = {0}", sum.ToString("F5"));
        }

        // Use recursive method
        private static int GetFactorial(int number)
        {
            if( number == 1)
            {
                return 1;
            }
             return number * GetFactorial(number - 1);
        }
    }

