
//Problem 11. Prefix "test"

//    Write a program that deletes from a text file all words that start
//    with the prefix test.
//    Words contain only the symbols 0…9, a…z, A…Z, _.


using System;
using System.IO;
using System.Text.RegularExpressions;

class PrefixTest
{
    static void Main()
    {
        string FilePath = @"..\..\text.txt";
        Prefix(FilePath);
    }


    private static void Prefix(string FilePath)
    {
        string text;
        using (StreamReader streamReader = new StreamReader(FilePath))
        {
           
                    text = Regex.Replace(streamReader.ReadLine(), @"\btest\b", string.Empty);
                
            
        }
        using (StreamWriter streamWriter = new StreamWriter(FilePath))
        {
            streamWriter.Write(text);
        }

    }
}

