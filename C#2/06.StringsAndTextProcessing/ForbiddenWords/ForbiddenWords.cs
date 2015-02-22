
//Problem 9. Forbidden words

//    We are given a string containing a list of forbidden words and a text containing some of these words.
//    Write a program that replaces the forbidden words with asterisks.


using System;
using System.Text.RegularExpressions;

class ForbiddenWords
{
    static void Main()
    {
        string inputText = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        Console.WriteLine(Regex.Replace(inputText, "(PHP|CLR|Microsoft)", word => new string('*', word.Length)));
    }
}

