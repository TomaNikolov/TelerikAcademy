
//Problem 14. Decimal to Binary Number

//    Using loops write a program that converts an integer number to
//its binary representation.
//    The input is entered as long. The output should be a variable
//of type string.
//    Do not use the built-in .NET functionality.


using System;
using System.Collections.Generic;


class DecimalToBinaryNumber
{
    static void Main()
    {
        Console.Write("Enter number: ");
        long number = int.Parse(Console.ReadLine());
        List<long> binary = new List<long>(10);
        do
        {
            binary.Add(number % 2);
            number /= 2;
        } while (number > 0);

        binary.Reverse();
        foreach (var bit in binary)
        {
            Console.Write(bit);
        }
        Console.WriteLine();
    }
}

