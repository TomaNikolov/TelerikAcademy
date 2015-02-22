
//Problem 13. Count words

//    Write a program that reads a list of words from the file words.txt and finds how many times each of the words is contained in another file test.txt.
//    The result should be written in the file result.txt and the words should be sorted by the number of their occurrences in descending order.
//    Handle all possible exceptions in your methods.


using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Linq;

class CountWords
{
    static void Main()
    {
        try
        {
            string wordsFilePath = @"..\..\words.txt";
            string FilePath = @"..\..\text.txt";
            string resultFilePath = @"..\..\result.txt";
            Dictionary<string, int> words = GetWordsList(wordsFilePath);
            CountOccures(FilePath, resultFilePath, words);
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

    private static Dictionary<string, int> GetWordsList(string wordsFilePath)
    {
        Dictionary<string, int> result = new Dictionary<string, int>();
        using (StreamReader streamReader = new StreamReader(wordsFilePath))
        {
            while (!streamReader.EndOfStream)
            {
                string[] line = streamReader.ReadLine().Split(new[] { ' ', ',', '.' },
                                               StringSplitOptions.RemoveEmptyEntries);
                foreach (var word in line)
                {
                    if (!result.ContainsKey(word))
                    {
                        result.Add(word, 0);
                    }
                }
            }
            return result;
        }

    }


    private static void CountOccures(string FilePath, string resultFilePath, Dictionary<string, int> words)
    {

        using (StreamReader streamReader = new StreamReader(FilePath))
        {
            using (StreamWriter streamWriter = new StreamWriter(resultFilePath))
            {
                string text = streamReader.ReadToEnd();

                for (int i = 0; i < words.Count; i++)
                {
                    KeyValuePair<string, int> word = words.ElementAt(i);
                    int index = text.IndexOf(word.Key, StringComparison.Ordinal);
                    while (index != -1)
                    {
                        words[word.Key]++;
                        index = text.IndexOf(word.Key, index + 1, StringComparison.Ordinal);
                    }
                }
                foreach (KeyValuePair<string, int> word in words.OrderByDescending(key => key.Value))
                    streamWriter.WriteLine(word.Key + " : " + word.Value);
            }
        }
    }

}

