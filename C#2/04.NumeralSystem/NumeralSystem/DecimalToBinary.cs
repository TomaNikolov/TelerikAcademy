
//Problem 1. Decimal to binary

//    Write a program to convert decimal numbers to their binary representation.


using System;
using System.Collections.Generic;

class NumeralSystem
{
    static void Main()
    {

        Console.Write("Enter number: ");
        long number = int.Parse(Console.ReadLine());
        List<long> binary = DecimalToBinary(number);
        Print(binary);
        
    }

    private static void Print(List<long> binary)
    {
        foreach (var bit in binary)
        {
            Console.Write(bit);
        }
        Console.WriteLine();
    }

    private static List<long> DecimalToBinary(long number)
    {
        List<long> binary = new List<long>(10);
        do
        {
            binary.Add(number % 2);
            number /= 2;
        } while (number > 0);

        binary.Reverse();
        return binary;
    }
}

