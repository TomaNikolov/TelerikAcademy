using System;

namespace ExtractBitFromInteger
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Enter position: ");
            int posistion = int.Parse(Console.ReadLine());
            number >>= posistion;
            int mask = 1;
            int maskAndNumber = number & mask;
            Console.WriteLine("Value of bit #{0} is: {1}", posistion, maskAndNumber);
        }
    }
}
