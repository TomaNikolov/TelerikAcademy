
//Reverse sentence

//    Write a program that reverses the words in given sentence.


using System;
using System.Text.RegularExpressions;

class ReverseSentence
{
    static void Main()
    {
        string sentence = "C# is not C++, not PHP and not Delphi!";
        char getSign = sentence[sentence.Length - 1];
        sentence = sentence.Remove(sentence.Length - 1);
        string[] words = sentence.Split(new[]{' '}, StringSplitOptions.RemoveEmptyEntries);
        Array.Reverse(words);
        Console.WriteLine(string.Join(" ", words) + getSign);
    }
}
