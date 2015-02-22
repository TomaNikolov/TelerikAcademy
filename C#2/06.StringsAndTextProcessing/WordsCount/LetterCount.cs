
//Problem 21. Letters count

//    Write a program that reads a string from the console and prints
//    all different letters in the string along with information how many
//    times each letter is found.


using System;
using System.Collections.Generic;

class WordsCount
{
    static void Main()
    {
        string inputText = "TextText"; //Console.WriteLine();
        var dict = new Dictionary<char, int>();
        for (int i = 0; i < inputText.Length; i++)
        {
            if(dict.ContainsKey(inputText[i]))
            {
                dict[inputText[i]]++;
            }
            else if(char.IsLetter(inputText[i]))
            {
                dict.Add(inputText[i], 1);

            }
        }
        foreach (var item in dict)
        {
            Console.WriteLine("Letter: {0} Count: {1}", item.Key, item.Value);
        }
    }
}

