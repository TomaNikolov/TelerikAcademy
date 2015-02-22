
//Problem 19. Dates from text in Canada

//    Write a program that extracts from a given text all dates that
//    match the format DD.MM.YYYY.
//    Display them in the standard date format for Canada.


using System;
using System.Text.RegularExpressions;
using System.Globalization;

class DatesFromTextInCanada
{
    static void Main()
    {
        string input = "Text, 02.02.2015 dasdasd, tesda. 24.04.2014";
        var dates = Regex.Matches(input, "([0-9]{2}).([0-9]{2}).([0-9]{4})");
        CultureInfo provider = CultureInfo.GetCultureInfo("en-CA");
        foreach (var date in dates)
        {
            Console.WriteLine(DateTime.Parse(date.ToString(), provider));
        }
    }
}

