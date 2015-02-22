
//Problem 1. Odd lines

//    Write a program that reads a text file and prints on the console its odd lines.


using System;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            string filePath = @"C:\Windows\win.ini";
            StreamReader streamReader = new StreamReader(filePath);
            using (streamReader)
            {
                int line = 0;
                string textLine = streamReader.ReadLine();
                while (textLine != null)
                {

                    if (line % 2 != 0)
                    {
                        Console.WriteLine(textLine);
                    }
                    textLine = streamReader.ReadLine();
                    line++;
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

