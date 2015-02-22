
//Problem 8. Binary short

//    Write a program that shows the binary representation of given
//    16-bit signed integer number (the C# type short).


using System;

class BinaryShort
{
    static void Main()
    {
        Console.Write("Enter Number");
        short number = short.Parse(Console.ReadLine());
        string binary = Convert.ToString(number, 2).PadLeft(16, '0');
        Console.WriteLine(binary);
    }
}

