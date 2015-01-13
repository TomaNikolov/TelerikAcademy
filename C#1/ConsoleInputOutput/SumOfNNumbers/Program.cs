using System;

namespace SumOfNNumbers
{
    class Program
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
}
