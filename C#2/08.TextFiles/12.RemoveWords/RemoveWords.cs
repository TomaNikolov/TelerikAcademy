
//Problem 12. Remove words

//    Write a program that removes from a text file all words listed in given another text file.
//    Handle all possible exceptions in your methods.


using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Linq;

class RemoveWords
{
    static void Main()
    {
        try
        {
            string wordsFilePath = @"..\..\words.txt";
            string FilePath = @"..\..\text.txt";
            string resultFilePath = @"..\..\result.txt";
            List<string> words = GetRemoveWordsList(wordsFilePath);
            Remove(FilePath, resultFilePath, words);
        }
        catch (OutOfMemoryException)
        {

            Console.WriteLine("Input file is too big!");
        }
        catch (FileNotFoundException)
        {

            Console.WriteLine("File not found, or you don't have administrator permissions");
        }
        catch (ArgumentNullException)
        {

            Console.WriteLine("Some Method received a null argument!");
        }
        catch (IOException)
        {

            Console.WriteLine("An IO exception occurred");
        }
    }

    private static List<string> GetRemoveWordsList(string wordsFilePath)
    {
        List<string> result = new List<string>();
        using (StreamReader streamReader = new StreamReader(wordsFilePath))
        {
            string line = streamReader.ReadLine();
            while (line != null)
            {
                result.Add(line.Trim());
                line = streamReader.ReadLine();
            }
            return result;
        }

    }


    private static void Remove(string FilePath, string resultFilePath, List<string> words)
    {

        using (StreamReader streamReader = new StreamReader(FilePath))
        {
            using (StreamWriter streamWriter = new StreamWriter(resultFilePath))
            {
                while (!streamReader.EndOfStream)
                {
                    string text = streamReader.ReadLine();
                    text = words.Aggregate(text, (current, x) => Regex.Replace(current, "\\b" + x + "\\b", string.Empty));
                    streamWriter.Write(text);
                }
            }
        }

    }
}

