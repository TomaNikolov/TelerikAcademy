using System;


namespace ExchangeVariableValues
{
    class Program
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            Console.WriteLine(a);
            Console.WriteLine(b);

            int x = a;
            a = b;
            b = x;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
