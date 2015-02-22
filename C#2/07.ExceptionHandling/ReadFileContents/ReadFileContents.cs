
//Problem 3. Read file contents

//    Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
//    Find in MSDN how to use System.IO.File.ReadAllText(…).
//    Be sure to catch all possible exceptions and print user-friendly error messages.


using System;
using System.IO;

class ReadFileContents
{
    static void Main()
    {
        try
        {
            string fileName = @"C:\Windows\win.ini";
            StreamReader streamReader = new StreamReader(fileName);
            using (streamReader)
            {
                string fileContents = streamReader.ReadToEnd();
                Console.WriteLine(fileContents);
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

