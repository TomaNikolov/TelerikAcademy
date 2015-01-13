using System;

namespace BitExchange
{
    class Program
    {
      static  uint number = 0;
        static void Main()
        {
            Console.Write("Enter a number: ");
             number = uint.Parse(Console.ReadLine());

            for (int i = 3; i <= 5; i++)
            {
                uint firstResult = ZeroOrOne(i);
                uint secondResult = ZeroOrOne(i + 21);
                ChangeBit(i, secondResult);
                ChangeBit((i + 21), firstResult); 
            }
            Console.WriteLine(number);
        }

        private static void ChangeBit(int bitPosition, uint result )
        {
            uint mask;

            if (result == 0)
            {
                mask = (uint)1 << bitPosition;
                 number = number & (~ mask);
            }
            else
            {
                mask = (uint)1 << bitPosition;
                 number = number | mask;
            }
        }
        private static uint  ZeroOrOne(int position)
        {
            uint mask = (uint)1 << position;
            uint maskAndNumber = number & mask;
            uint result = maskAndNumber >> position;

            return result;

        }
    }
}
