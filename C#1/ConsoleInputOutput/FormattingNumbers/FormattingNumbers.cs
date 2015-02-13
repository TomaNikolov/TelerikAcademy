
//Problem 5. Formatting Numbers

//    Write a program that reads 3 numbers:
//        integer a (0 <= a <= 500)
//        floating-point b
//        floating-point c
//    The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
//        The number a should be printed in hexadecimal, left aligned
//        Then the number a should be printed in binary form, padded with zeroes
//        The number b should be printed with 2 digits after the decimal point, right aligned
//        The number c should be printed with 3 digits after the decimal point, left aligned.


using System;
using System.Globalization;

class FormattingNumbers
{
    static void Main()
    {
        Console.Write("Enter  a: ");
        int a = int.Parse(Console.ReadLine());

        while (a <= 0 || a >= 500)
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

