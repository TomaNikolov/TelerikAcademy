
//Problem 2. Binary to decimal

//    Write a program to convert binary numbers to their decimal representation.


using System;

class BinaryToDecimal
{
    static void Main()
    {
          Console.Write("Enter binary number:");
        string binaryNumbre = Console.ReadLine().Trim();
        int sum = 0;

        for (int i = binaryNumbre.Length - 1, pow = 0; i >= 0; i--, pow++)
        {
            sum += int.Parse(binaryNumbre[i].ToString()) * (int)Math.Pow(2, pow);
        }

        Console.WriteLine("Number is : {0}", sum);
    }
    }


