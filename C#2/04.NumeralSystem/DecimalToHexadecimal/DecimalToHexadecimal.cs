
//Problem 3. Decimal to hexadecimal

//    Write a program to convert decimal numbers to their hexadecimal representation.



using System;
using System.Collections.Generic;

class DecimalToHexadecimal
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        long decimalNumber = long.Parse(Console.ReadLine());
        List<string> hexNumber = new List<string>();

        do
        {
            string hexValue = "" + (decimalNumber % 16).ToString();

            if (hexValue == "10")
            {
                hexValue = "A";
            }
            if (hexValue == "11")
            {
                hexValue = "B";
            }
            if (hexValue == "12")
            {
                hexValue = "C";
            }
            if (hexValue == "13")
            {
                hexValue = "D";
            }
            if (hexValue == "14")
            {
                hexValue = "E";
            }
            if (hexValue == "15")
            {
                hexValue = "F";
            }
            decimalNumber /= 16;
            hexNumber.Add(hexValue);

        } while (decimalNumber > 0);

        hexNumber.Reverse();
        Console.Write("Number in hexadecimal is: ");

        foreach (var hex in hexNumber)
        {
            Console.Write(hex);
        }
        Console.WriteLine();
    }
}

