using System;

namespace SumOfFiveNumbers
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter  5 numbers separated by  a space: ");
            string [] numbers = Console.ReadLine().Split(' ');
            
            double sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {

                sum += Convert.ToDouble(numbers[i]);
            }
            Console.WriteLine("Sum is {0}", sum);
        }
    }
}
