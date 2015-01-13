using System;
using System.Text;

namespace FibonaccNumbers
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter  n > 0: ");
            int n = int.Parse(Console.ReadLine());

            int [] fibonacciNumbers = new int [n];
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
                if(i == n -1)
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
}
