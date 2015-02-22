
//Problem 20. Palindromes

//    Write a program that extracts from a given text all palindromes,
//    e.g. ABBA, lamal, exe.

using System;
using System.Text.RegularExpressions;
using System.Linq;

class Polindromes
{
    static void Main()
    {
        string text = " ABBA something else, lamal, bubu, exe.";
        var words = Regex.Matches(text, "\\w(?<!\\d)[\\w'-]*");
        foreach (var word in words)
        {
            if(IsPolindrome(word.ToString()))
            {
                Console.WriteLine(word);
            }
        }
    }

    private static bool IsPolindrome(string word)
    {
        return word.ToCharArray().SequenceEqual(word.ToCharArray().Reverse());     
    }
}

