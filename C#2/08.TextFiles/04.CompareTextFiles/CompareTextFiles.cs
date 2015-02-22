using System;
using System.IO;

class CompareTextFiles
{
    static void Main()
    {
        try
        {
            string firstFilPath = @"..\..\FirstFile.txt"; ;
            string secondFilePath = @"..\..\SecondFile.txt";
            StreamReader firstReader = new StreamReader(firstFilPath);
            StreamReader secondReader = new StreamReader(secondFilePath);
            string firstTextLine = "";
            string secondTextLine = "";
            using (firstReader)
            {


                using (secondReader)
                {
                    firstTextLine = firstReader.ReadLine();
                    secondTextLine = secondReader.ReadLine();
                    int lineNumber = 1;
                    while (firstTextLine != null)
                    {

                        if (firstTextLine.Equals(secondTextLine))
                        {
                            Console.WriteLine("Same line: {0}", lineNumber);
                        }
                        else
                        {
                            Console.WriteLine("Differnt line: {0}", lineNumber);
                        }
                        firstTextLine = firstReader.ReadLine();
                        secondTextLine = secondReader.ReadLine();
                        lineNumber++;
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

