
//Problem 17. Date in Bulgarian

//    Write a program that reads a date and time given in the format: 
//    day.month.year hour:minute:second and prints the date and time
//    after 6 hours and 30 minutes (in the same format) along with the
//    day of week in Bulgarian.

using System;
using System.Globalization;
using System.Threading;

class Program
{
    static void Main()
    {
       

        try
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
            Console.Write("Enter first date in format [dd.MM.yyyy HH:mm:ss]:");
            DateTime Date = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy H:m:s", CultureInfo.GetCultureInfo("bg-BG"));
            Date.AddHours(6).AddMinutes(30);
            Console.WriteLine(string.Format("{0} {1}", Date.DayOfWeek, Date), CultureInfo.GetCultureInfo("bg-BG"));

           
        }
        catch (FormatException)
        {
            Console.WriteLine("Incorrect date format");
        }
    }
}

