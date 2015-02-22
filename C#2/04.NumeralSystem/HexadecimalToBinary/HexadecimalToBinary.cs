
//Problem 5. Hexadecimal to binary

//    Write a program to convert hexadecimal numbers to binary numbers (directly).


using System;
using System.Collections.Generic;
using System.Text;

class HexadecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        string hexNumber = Console.ReadLine().Trim();
        List<string> binary = new List<string>();

        for (int i = hexNumber.Length - 1, pow = 0; i >= 0; i--, pow++)
        {
            string hexValue = (hexNumber[i].ToString());
            for (int j = 0; j < 10; j++)
            {
                if(hexValue == j.ToString())
                {
                    hexValue = Convert.ToString(j, 2).PadLeft(4, '0').ToString();
                }
            }
            
            if (hexValue == "A" || hexValue == "a")
            {
                hexValue = "1010";
            }
            if (hexValue == "B" || hexValue == "b")
            {
                hexValue = "1011";
            }
            if (hexValue == "C" || hexValue == "c")
            {
                hexValue = "1100";
            }
            if (hexValue == "D" || hexValue == "d")
            {
                hexValue = "1101";
            }
            if (hexValue == "E" || hexValue == "e")
            {
                hexValue = "1110";
            }
            if (hexValue == "F" || hexValue == "f")
            {
                hexValue = "1111";
            }

            binary.Add(hexValue);
        }
        binary.Reverse();
        Console.Write("Number in decimal is: ");
        foreach (var item in binary)
        {
            Console.Write(item);
        }
        Console.WriteLine();
    }
}

