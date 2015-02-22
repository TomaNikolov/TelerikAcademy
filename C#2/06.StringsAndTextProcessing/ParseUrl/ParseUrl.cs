
//Problem 12. Parse URL

//    Write a program that parses an URL address given in the format:
//    [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.


using System;
using System.Text.RegularExpressions;

class ParseUrl
{
    static void Main()
    {
        string URL = "http://telerikacademy.com/Courses/Courses/Details/212";
        var result = Regex.Match(URL, "(.*)://(.*?)(/.*)").Groups;
        Console.WriteLine("URL: {0}", result[0]);
        Console.WriteLine("[protocol]: {0}", result[1]);
        Console.WriteLine("[server]: {0}", result[2]);
        Console.WriteLine("[resource]: {0}", result[3]);

    }
}

