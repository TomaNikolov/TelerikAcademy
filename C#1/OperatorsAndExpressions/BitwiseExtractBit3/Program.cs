using System;

namespace BitwiseExtractBit3
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a Number: ");
            int number = int.Parse(Console.ReadLine());

            //number >>=  3;
            //int mask = 1;
            //int maskAndNumber = number & mask;
            //Console.WriteLine("Value of vit #3 is: {0}", maskAndNumber);

            int mask = 1 << 3;
            int maskAndNumber = mask & number;
            int result = maskAndNumber >> 3;
            Console.WriteLine("Value of bit #3 is: {0}", result);

        }
    }
}
