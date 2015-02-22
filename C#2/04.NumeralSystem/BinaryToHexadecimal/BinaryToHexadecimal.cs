
//Problem 6. binary to hexadecimal

//    Write a program to convert binary numbers to hexadecimal numbers (directly).


using System;
using System.Collections.Generic;
using System.Text;

class BinaryToHexadecimal
{
    static void Main()
    {
        Console.Write("Enter binary number:");
        string binaryNumbre = Console.ReadLine();
        List<string> hex = new List<string>();
        int leadingZiro = 4 - (binaryNumbre.Length % 4);
        binaryNumbre = binaryNumbre.PadLeft(leadingZiro + binaryNumbre.Length, '0');
       

        for (int i = 0; i < binaryNumbre.Length; i += 4)
        {
            string result = "";
            for (int j = i; j < i + 4; j++)
            {
                result += binaryNumbre[j];
            }
            switch (result.ToString())
            {
                case "0000": result = "0"; break;
                case "0001": result = "1"; break;
                case "0010": result = "2"; break;
                case "0011": result = "3"; break;
                case "0100": result = "4"; break;
                case "0101": result = "5"; break;
                case "0110": result = "6"; break;
                case "0111": result = "7"; break;
                case "1000": result = "8"; break;
                case "1001": result = "9"; break;
                case "1010": result = "A"; break;
                case "1011": result = "B"; break;
                case "1100": result = "C"; break;
                case "1101": result = "D"; break;
                case "1110": result = "E"; break;
                case "1111": result = "F"; break;
                default:
                    break;
            }
            hex.Add(result);
        }
        Console.Write("Number hexadeciaml is: ");
        foreach (var digit in hex)
        {
            Console.Write(digit);
        }
        Console.WriteLine();
    }
}

