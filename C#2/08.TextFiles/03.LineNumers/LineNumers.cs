
//Problem 3. Line numbers

//    Write a program that reads a text file and inserts line numbers
//    in front of each of its lines.
//    The result should be written to another text file.


using System;
using System.IO;

class LineNumers
{
    public static void Main()
    {
        try
        {
            string FilPath = @"C:\Windows\win.ini";
            string TextWithLineNumber = @"TextWithLineNumber.txt";
            StreamReader streamReader = new StreamReader(FilPath);
            StreamWriter streamWriter = new StreamWriter(TextWithLineNumber);
            string textLine = "";
            using (streamReader)
            {
                int lineNumber = 1;
                    using (streamWriter)
                    {
                        textLine = streamReader.ReadLine();
                        while (textLine != null)
                        {
                            streamWriter.WriteLine("{0} {1}", lineNumber, textLine);
                            Console.WriteLine("{0} {1}", lineNumber, textLine);
                            textLine = streamReader.ReadLine();
                            lineNumber++;
                        }
                    }
                
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

