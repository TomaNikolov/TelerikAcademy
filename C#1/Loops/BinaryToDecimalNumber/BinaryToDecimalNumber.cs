
//Problem 13. Binary to Decimal Number

//    Using loops write a program that converts a binary integer number 
//to its decimal form.
//    The input is entered as string. The output should be a variable of 
//type long.
//    Do not use the built-in .NET functionality.


using System;


class BinaryToDecimalNumber
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

