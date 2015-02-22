
//Problem 4. Hexadecimal to decimal

//    Write a program to convert hexadecimal numbers to their decimal representation.


using System;

class HexadecimalToDecimal
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        string hexNumber = Console.ReadLine().Trim();
        long sum = 0;

        for (int i = hexNumber.Length - 1, pow = 0; i >= 0; i--, pow++)
        {
            string hexValue = (hexNumber[i].ToString());
            if (hexValue == "A" || hexValue == "a")
            {
                hexValue = "10";
            }
            if (hexValue == "B" || hexValue == "b")
            {
                hexValue = "11";
            }
            if (hexValue == "C" || hexValue == "c")
            {
                hexValue = "12";
            }
            if (hexValue == "D" || hexValue == "d")
            {
                hexValue = "13";
            }
            if (hexValue == "E" || hexValue == "e")
            {
                hexValue = "14";
            }
            if (hexValue == "F" || hexValue == "f")
            {
                hexValue = "15";
            }

            sum += int.Parse(hexValue.ToString()) * (long)Math.Pow(16, pow);
        }
        Console.WriteLine("Number in decimal is: " + sum);
    }
}

