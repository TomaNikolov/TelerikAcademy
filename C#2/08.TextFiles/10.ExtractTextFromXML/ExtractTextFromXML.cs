
//Problem 10. Extract text from XML

//    Write a program that extracts from given XML file all the text without the tags.


using System;
using System.IO;
using System.Text.RegularExpressions;

class ExtractTextFromXML
{
    static void Main()
    {
        string FilPath = @"..\..\text.xml";
        ExtractText(FilPath);
    }


    private static void ExtractText(string firstFilPath)
    {
        using (StreamReader streamReader = new StreamReader(firstFilPath))
        {
            string[] words;
            words = Regex.Replace(streamReader.ReadLine(), @"<[^>]*>", " ")
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}

