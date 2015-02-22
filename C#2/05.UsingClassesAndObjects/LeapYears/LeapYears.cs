//Problem 1. Leap year

//    Write a program that reads a year from the console and checks whether
//    it is a leap one.
//    Use System.DateTime.


using System;

class LeapYear
{
    static void Main()
    {
        Console.Write("Enter year: ");
        DateTime yearsLeap = new DateTime(int.Parse(Console.ReadLine()), 1, 1);
        Console.WriteLine("{0} is {1}.", yearsLeap.Year, DateTime.IsLeapYear(yearsLeap.Year) ? "leap" : "not leap");
    }
}