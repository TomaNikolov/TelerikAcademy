
//Problem 6. Save sorted names

//    Write a program that reads a text file containing a list of strings, 
//    sorts them and saves them to another text file.


using System;
using System.IO;
using System.Collections.Generic;

class SaveSortedNames
{
    static void Main()
    {
        try
        {
            string firstFilPath = @"..\..\names.txt";
            StreamReader streamReader = new StreamReader(firstFilPath);
            string textLine;
            List<string> names = new List<string>();
            using (streamReader)
            {
                textLine = streamReader.ReadLine();
                while (textLine != null)
                {
                    names.Add(textLine);
                    textLine = streamReader.ReadLine();
                }
                names.Sort();
                string writeFailPath = @"..\..\result.txt";
                StreamWriter streamWriter = new StreamWriter(writeFailPath);
                using (streamWriter)
                {
                    foreach (var name in names)
                    {
                        streamWriter.WriteLine(name);
                    }
                    
                }
            }

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
}


