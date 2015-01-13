using System;
using System.Globalization;

namespace PrintTheAsciiTable
{
    class Program
    {
        static void Main()
        {
            Console.BufferHeight = 256;

            for (int i = 0; i <= 255; i++)
            {
                char ch = (char)i;
                Console.WriteLine("{0} --> {1}", i, ch);
            }
        }
    }
}
