
//Problem 23. Series of letters

//    Write a program that reads a string from the console
//    and replaces all series of consecutive identical letters with a single one.


using System;
using System.Collections.Generic;

class SeriesOfLetters
{
    static void Main()
    {
        string inputText = "aaaaabbbbbcdddeeeedssaa"; //Console.WriteLine();
        var set = new HashSet<char>();
        for (int i = 0; i < inputText.Length; i++)
        { 
            if (char.IsLetter(inputText[i]))
            {
                set.Add(inputText[i]);

            }
        }
        Console.Write("Output: ");
        foreach (var item in set)
        {
            Console.Write(item.ToString());
        }
        Console.WriteLine();
    }
}

