
//Problem 2. Concatenate text files

//    Write a program that concatenates two text files into another text file.


using System;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            string firstFilPath = @"C:\Windows\win.ini";
            string secondFilePath = @"C:\Windows\system.ini";
            string concatenateText = @"concatenate.txt";
            StreamReader firstReader = new StreamReader(firstFilPath);
            StreamReader secondReader = new StreamReader(secondFilePath);
            StreamWriter streamWriter = new StreamWriter(concatenateText);
            string firstText = "";
            string secondText = "";
            using (firstReader)
            {
                firstText = firstReader.ReadToEnd();
            }
            using (secondReader)
            {
                secondText = secondReader.ReadToEnd();
            }
            using (streamWriter)
            {
                streamWriter.Write(firstText, true);
                streamWriter.Write(secondText, true);
            }
            Console.WriteLine("File write complete");

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

