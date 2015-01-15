
//Write a program that shows the sign (+, - or 0) of the product of three real 
//numbers, without calculating it.

//    Use a sequence of if operators.


using System;

namespace MultiplicationOfSign
{
    class Program
    {
        static void Main()
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());

            if(a == 0 && b == 0 && c == 0 || a > 0 && b < 0 && c == 0 || a < 0 && b > 0 && c == 0 || a > 0 && b == 0 && c < 0 || a < 0 && b == 0 && c > 0 || a == 0 && b > 0 && c < 0 || a == 0 && b < 0 && c > 0) 
            {
                Console.WriteLine(0);
            }
            else if(a > 0 && b > 0 && c > 0 || a > 0 && b > 0 || b > 0 && c > 0 || a > 0 && c > 0)
            {
                Console.WriteLine("+");
            }
            else if(a < 0 && b < 0 && c < 0 || a < 0 && b < 0 || b < 0 && c < 0 || a < 0 && c < 0)
            {
                Console.WriteLine("-");
            }
            else
            {
                Random randomSign = new Random();
                char[] sign = new char[] { '+', '-', '0' };
                Console.WriteLine(randomSign.Next(3));
            }
        }
    }
}
