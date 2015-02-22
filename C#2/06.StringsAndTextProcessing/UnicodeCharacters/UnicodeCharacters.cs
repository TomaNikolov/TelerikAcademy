
//Problem 10. Unicode characters

//    Write a program that converts a string to a sequence of C# Unicode character literals.
//    Use format strings.


using System;

class UnicodeCharacters
{
    static void Main()
    {
        Console.Write("Enter text: ");
        string inputText = Console.ReadLine();
        for (int i = 0; i < inputText.Length; i++)
        {
            int unicodeChar = inputText[i];
            Console.Write("\\u{0:X4}", unicodeChar);
        }
        Console.WriteLine();
    }
}

