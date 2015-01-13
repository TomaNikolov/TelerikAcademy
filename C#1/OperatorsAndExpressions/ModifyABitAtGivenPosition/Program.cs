using System;

namespace ModifyABitAtGivenPosition
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Enter position: ");
            int position = int.Parse(Console.ReadLine());

            Console.Write("Enter bit value: ");
            int bitvalue = int.Parse(Console.ReadLine());

         

            if (bitvalue ==1)
            {
               int mask = 1 << position;
                int result = number | mask;
                Console.WriteLine("Resuult is: {0}", result);
            }
            else
            {
              int mask = 1 << position;
                int result = number & (~ mask);
                Console.WriteLine("Resuult is: {0}", result);
            }
        }
    }
}
