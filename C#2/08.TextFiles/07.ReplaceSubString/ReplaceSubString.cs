
//Problem 7. Replace sub-string

//    Write a program that replaces all occurrences of the sub-string start
//    with the sub-string finish in a text file.
//    Ensure it will work with large files (e.g. 100 MB).


using System;
using System.IO;

class ReplaceSubString
{
    static void Main()
    {
        string firstFilPath = @"..\..\text.txt";
        string resultFilPath = @"..\..\result.txt";

        ReoplaseSubString(firstFilPath, resultFilPath);
    }


    private static void ReoplaseSubString(string firstFilPath, string resultFilPath)
    {
        using (StreamReader streamReader = new StreamReader(firstFilPath))
        {
            using (StreamWriter streamWriter = new StreamWriter(resultFilPath))
            {

                while (!streamReader.EndOfStream)
                {
                    streamWriter.WriteLine(streamReader.ReadLine().Replace("start", "finish"));
                }
            }
        }
    }
}

