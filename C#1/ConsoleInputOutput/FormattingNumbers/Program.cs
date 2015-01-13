using System;
using System.Globalization;

namespace FormattingNumbers
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter  a: ");
            int a = int.Parse(Console.ReadLine());
            while(a <= 0 || a >= 500)
            {
                Console.WriteLine("a need to be in range 0 <= a <= 500");
                Console.Write("Enter  a: ");
                 a = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter  b: ");
            float b = float.Parse(Console.ReadLine());

            Console.Write("Enter  c: ");
            float c = float.Parse(Console.ReadLine());

            Console.Write("{0,-10}|", Convert.ToString(a, 16).ToUpper());
            Console.Write("{0}|", Convert.ToString(a, 2).PadLeft(10, '0'));
            Console.Write("{0,10}|", b.ToString("F2", CultureInfo.InvariantCulture));
            Console.Write("{0,-10}|", c.ToString("F3", CultureInfo.InvariantCulture));


        }
    }
}
