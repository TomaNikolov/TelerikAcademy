
//Problem 14. Word dictionary

//    A dictionary is stored as a sequence of text lines containing words and their explanations.
//    Write a program that enters a word and translates it by using the dictionary.


using System;
using System.Collections.Generic;

class WordDictionary
{
    static void Main()
    {
        var dict = new Dictionary<string, string>
        {
        {".NET", "platform for applications from Microsoft"},
        {"CLR", "managed execution environment for .NET"},
        {"NAMESPACE", "hierarchical organization of classes"}
        };
        Console.Write("Enter .Net, CLR, or NAMESPACES :");
        string key = Console.ReadLine();
        Console.WriteLine(dict.ContainsKey(key) ? string.Format("{0} - {1}", key, dict[key]) : "Word does not contains in dictionary");

    }
}

