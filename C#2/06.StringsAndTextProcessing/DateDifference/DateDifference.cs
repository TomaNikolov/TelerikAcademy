
//Problem 16. Date difference

//    Write a program that reads two dates in the format: day.month.year
//    and calculates the number of days between them.


using System;
using System.Globalization;

class DateDifference
{
    static void Main()
    {
        try
        {
            Console.Write("Enter first date in format day.mount.year:");
            DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);
            Console.Write("Enter second date in format day.mount.year:");
            DateTime secondDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);
            TimeSpan days;

            if(firstDate.CompareTo(secondDate) > 0)
            {
               days =  firstDate.Subtract(secondDate);
            }
            else
            {
                days = secondDate.Subtract(firstDate);
            }
            Console.WriteLine(days.Days);
        }
        catch(FormatException)
        {
            Console.WriteLine("Incorrect date format");
        }
    }
}

