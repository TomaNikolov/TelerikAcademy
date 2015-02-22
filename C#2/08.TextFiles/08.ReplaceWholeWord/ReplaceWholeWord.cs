
//Problem 8. Replace whole word

//    Modify the solution of the previous problem to replace
//    only whole words (not strings).


using System;
using System.IO;
using System.Text.RegularExpressions;

class ReplaceWholeWord
{
    static void Main()
    {
        string firstFilPath = @"..\..\text.txt";
        string resultFilPath = @"..\..\result.txt";

        ReoplaseWord(firstFilPath, resultFilPath);
    }


    private static void ReoplaseWord(string firstFilPath, string resultFilPath)
    {
        using (StreamReader streamReader = new StreamReader(firstFilPath))
        {
            using (StreamWriter streamWriter = new StreamWriter(resultFilPath))
            {

                while (!streamReader.EndOfStream)
                {
                    streamWriter.WriteLine(Regex.Replace(streamReader.ReadLine(), @"\bstart\b", "finish"));
                }
            }
        }
    }
}

