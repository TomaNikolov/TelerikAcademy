using System;
using System.Text;

namespace IsoscelesTriangle
{
    class Program
    {
        static void Main()
        {
            char copyrightSymbols = '\u00a9';
            Console.OutputEncoding = Encoding.UTF8;

            //   ©

            //  © ©

            // ©   ©

            //© © © ©


            Console.WriteLine("       " + copyrightSymbols);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("     " + copyrightSymbols + " " + copyrightSymbols);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("    " + copyrightSymbols + "   " + copyrightSymbols);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("  " + copyrightSymbols + " " + copyrightSymbols + " " + copyrightSymbols + " " + copyrightSymbols);

        }
    }
}

