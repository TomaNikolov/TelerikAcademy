using System;

namespace DividedBy7And5
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a number: ");

            int number = int.Parse(Console.ReadLine());

            if(number % 7 == 0 && number % 5 == 0)
            {
                Console.WriteLine("The number is divided by 7 and 5.");
            }
            else
            {
                Console.WriteLine("The number is not divided by 7 and 5.");
            }
        }
    }
}
