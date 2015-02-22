
//Problem 4. Download file

//    Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
//    Find in Google how to download files in C#.
//    Be sure to catch all exceptions and to free any used resources in the finally block.


using System;
using System.Net;

class DownloadFile
{
    static void Main()
    {
        try
        {
            string filePath = @"http://telerikacademy.com/Content/Images/news-img01.png";
            string saveFile = @"ninja.jpg";
            WebClient webClient = new WebClient();
            using (webClient)
            {
                webClient.DownloadFileAsync(new Uri(filePath), saveFile);
            }

        }
        catch (ArgumentNullException)
        {

            Console.WriteLine("The address or file name, parameter is null.");
        }
        catch (WebException)
        {

            Console.WriteLine("The file does not exist, or file name is empty.");
        }
        catch (NotSupportedException)
        {

            Console.WriteLine("The method has been called simultaneously on multiple threads.");
        }
    }
}

