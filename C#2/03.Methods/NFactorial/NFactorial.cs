
////Problem 10. N Factorial

////    Write a program to calculate n! for each n in the range [1..100].

using System;
using System.Numerics;

public class NFactorial
{
    public static void Main()
    {
     
        for (int index = 1; index <= 100; index++)
        {
            Console.WriteLine(" {0}! = {1}\n", index, GetFactorial(index));
        }
    }
    private static BigInteger GetFactorial(int number)
    {
        if (number == 0)
        {
            return 1;
        }
        return number * GetFactorial(number - 1);
    }
}
