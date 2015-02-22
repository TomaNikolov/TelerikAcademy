
//Problem 18. Extract e-mails

//    Write a program for extracting all email addresses from given text.
//    All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.


using System;
using System.Text.RegularExpressions;

class ExtractEMails
{
    static void Main()
    {
        string input = "Text, sda@gmail.com dasdasd, tesda. fghare@gami.com";
        var emails = Regex.Matches(input, "\\w+@[\\w.-]+|\\{(?:\\w+, *)+\\w+\\}@[\\w.-]+");
        foreach (var email in emails)
        {
            Console.WriteLine(email);
        }
    }
}

