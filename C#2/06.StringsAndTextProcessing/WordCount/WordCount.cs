
//Problem 22. Words count

//    Write a program that reads a string from the console
//   and lists all different words in the string along with
//   information how many times each word is found.

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class WordCount
{
    static void Main()
    {
        string inputText = "Text Text some other text"; //Console.WriteLine();
        var dict = new Dictionary<string, int>();
        var words = Regex.Matches(inputText, "\\w(?<!\\d)[\\w'-]*");
        foreach (var word in words)
        {
            if (dict.ContainsKey(word.ToString()))
            {
                dict[word.ToString()]++;
            }
            else
            {
                dict.Add(word.ToString(), 1);

            }
        }
        foreach (var item in dict)
        {
            Console.WriteLine("Word: {0} Count: {1}", item.Key, item.Value);
        }
    }
}

