
//Problem 1. Strings in C

//    Describe the strings in C#.
//    What is typical for the string data type?
//    Describe the most important methods of the String class.


using System;

class StringInC
{
    static void Main()
    {
        const string str = "Strings" ;
        Console.SetCursorPosition(Console.WindowWidth / 2 - str.Length / 2, 0);
        Console.WriteLine(str);
        Console.WriteLine();
        Console.WriteLine("Nearly every program uses strings. In strings, we find characters, words and textual data. The string type allows us to test and manipulate character data.");
        Console.WriteLine();
        Console.WriteLine("A string is immutable. It can be used in many methods, and none of them have to worry about data changes. It never becomes invalid. This reduces copies and makes programs more robust.");
        Console.WriteLine();
        Console.WriteLine("A string method, Split() separates at string and character delimiters. Even if we want just one part from a string, Split is useful. It returns a string array.");
        Console.WriteLine();
        Console.WriteLine("The Trim method is used with no parameters, meaning it uses a default set of whitespace characters to Trim.");
        Console.WriteLine();
        Console.WriteLine("Substring. This method extracts strings. It requires the location of the substring (a start index, a length). It then returns a new string with the characters in that range.");
        Console.WriteLine();
        Console.WriteLine("Length.  Every string object has a length. Every character—no matter what it is—is counted in the Length property. Length is cached on the string type. It is possible to avoid exceptions while accessing Length.");
        Console.WriteLine();
        Console.WriteLine("Concat.  With concat two or more strings become one. It is possible to concatenate two or more strings with several syntax forms. We use the plus operator and the string.Concat method. The plus compiles into string.");


    }
}
