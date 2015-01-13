using System;

namespace CheckABitAtGivenPosition
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Enter position: ");
            int position = int.Parse(Console.ReadLine());
            number >>= position;
            int mask = 1;
            int maskAndNumber = number & mask;

            Console.WriteLine("Value of bit #{0} {1}.", position, (maskAndNumber == 1)?  "is 1" : "is not 1");
        }
    }
}
