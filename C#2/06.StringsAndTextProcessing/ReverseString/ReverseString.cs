
//Problem 2. Reverse string

//    Write a program that reads a string, reverses it and prints
//    the result at the console.


using System;

class ReverseString
{
    static void Main()
    {
        string inputString = "sample"; //Console.ReadLine();
        for (int i = inputString.Length -1; i >= 0 ; i--)
        {
            Console.Write(inputString[i]);
        }
        Console.WriteLine();
    }
}

