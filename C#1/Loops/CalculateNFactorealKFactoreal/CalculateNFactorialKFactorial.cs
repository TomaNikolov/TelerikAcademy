
//Problem 6. Calculate N! / K!

//    Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
//    Use only one loop.


using System;


    class CalculateNFactorialKFactorial
    {
        static void Main()
        {
             Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter K: ");
            int k = int.Parse(Console.ReadLine());
            int kFactorial = k;
            int nFactorial = n;
           
            for (int i = 1; i < n; i++)
            {
                if (k -i > 0)
                {
                    kFactorial *= (k - i);
                }
                nFactorial *= (n - i);
            }
            
            Console.WriteLine("N! / K! = {0}", (nFactorial / kFactorial));
        }
    }

