using System;

namespace NumbersInIntervalDividdableByGivenNumber
{
    class Program
    {
        static void Main()
        {

            Console.Write("Enter  start number: ");
            int startNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter  end number: ");
            int endNumber = int.Parse(Console.ReadLine());
            int result = 0;

            for (int i = startNumber; i <= endNumber; i++)
            {
                if (i % 5 == 0)
                {
                    result++;
                }
            }
            Console.WriteLine(result);
        }
    }
}
