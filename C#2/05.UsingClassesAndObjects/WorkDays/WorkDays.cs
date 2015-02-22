
//Problem 5. Workdays

//    Write a method that calculates the number of workdays between
//    today and given date, passed as parameter.
//    Consider that workdays are all days from Monday to Friday 
//    except a fixed list of public holidays specified preliminary as array.


using System;
using System.Collections.Generic;

class WorkDays
{
    static List<DateTime> Holidays = new List<DateTime>()
        {
          new DateTime(2015,1,1),
          new DateTime(2015,3,3),
          new DateTime(2015,4,10),
          new DateTime(2015,4,13),
          new DateTime(2015,4,13),
          new DateTime(2015,5,1),
          new DateTime(2015,5,6),
          new DateTime(2015,9,06),
          new DateTime(2015,11,1),
          new DateTime(2015,12,24),
          new DateTime(2015,12,25),
          new DateTime(2015,12,30)
        };
    static void Main()
    {
        DateTime today = DateTime.Now;
        Console.Write("Enter futuer date to calculate working days(mm:dd:yyyy): ");
        DateTime future = DateTime.Parse(Console.ReadLine());
        int wokingDays = CalculateWorkingDay(today, future);
        Console.WriteLine("From {0} to {1} have {2} working day.", 
             today.ToString("D"), future.ToString("D"), wokingDays);
    }

    private static int CalculateWorkingDay(DateTime today, DateTime future)
    {
        int workingDays = 0;
        while (today < future)
        {
            if((!Holidays.Contains(today))
                && (today.DayOfWeek != DayOfWeek.Saturday)
                && (today.DayOfWeek != DayOfWeek.Sunday))
            {
                workingDays++;
            }
           today = today.AddDays(1);
        }
        return workingDays;
    }
}

