using System;

namespace NumbersFromOneToN
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter  n: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
