using System;


namespace NullValueArithmetic
{
    class Program
    {
        static void Main()
        {
            int? a = null;
            double? b = null;

            Console.WriteLine("a = ", a);
            Console.WriteLine("b = ", b);

            a += 5;
            b += 10;

            Console.WriteLine("a + 5 =", a);
            Console.WriteLine("b + 5 =", b);
        }
    }
}
