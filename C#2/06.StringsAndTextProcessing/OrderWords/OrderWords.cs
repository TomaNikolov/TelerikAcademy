
//Problem 24. Order words

//    Write a program that reads a list of words,
//    separated by spaces and prints the list in an alphabetical order.


using System;

class OrderWords
{
    static void Main()
    {
        Console.Write("Enter a list of word separated by spaces: ");
        string[] words = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        Array.Sort(words);
        Console.WriteLine("Sorted words: {0}", string.Join(", ", words));
    }
}

