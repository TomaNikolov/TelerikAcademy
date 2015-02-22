
//Problem 8. Extract sentences

//    Write a program that extracts from a given text all sentences containing given word.


using System;
using System.Text.RegularExpressions;

class ExtractSentences
{
    static void Main()
    {
        // Console.Write("Enter word: ");
        string searchedWord = "in"; //Console.ReadLine();
        //Console.Write("Enter text: ");
        string inputText = " We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        //Console.ReadLine();
        MatchCollection x = Regex.Matches(inputText, "([A-Z][^.?!]*?)?(?<!\\w)(?i)(" + searchedWord + ")(?!\\w)[^.?!]*?[.?!]");
        foreach (var sentence in x)
        {
            Console.Write(sentence);
        }
        Console.WriteLine();

    }
}

