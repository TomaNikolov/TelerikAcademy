using System;

namespace ThirdDigitIsSeven
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a number: ");

            int number = int.Parse(Console.ReadLine());

            if (number < 100)
            {
                Console.WriteLine("Third digit is not seven.");
            }
            else
            {
                int devider = number / 100;
                devider = devider % 10;
                if (devider == 7)
                {
                    Console.WriteLine("Third digit is seven.");
                }
                else
                {
                    Console.WriteLine("Third digit is not seven.");
                }
            }
        }
    }
}
