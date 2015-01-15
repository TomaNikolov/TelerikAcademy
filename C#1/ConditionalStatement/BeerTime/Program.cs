

    //A beer time is after 1:00 PM and before 3:00 AM.
    //Write a program that enters a time in format “hh:mm tt” (an hour in range
    //[01...12], a minute in range [00…59] and AM / PM designator) and prints beer
    //time or non-beer time according to the definition above or invalid time if 
    //the time cannot be parsed. Note: You may need to learn how to parse dates
    //and times.


using System;
using System.Globalization;

namespace BeerTime
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a time: ");
            DateTime beerTime = DateTime.ParseExact(Console.ReadLine(), "hh:mm tt", CultureInfo.InvariantCulture);
            DateTime after = DateTime.ParseExact("01:00 PM", "hh:mm tt", CultureInfo.InvariantCulture);
            DateTime before = DateTime.ParseExact("03:00 AM", "hh:mm tt", CultureInfo.InvariantCulture);
            DateTime midnight = DateTime.ParseExact("00:00 AM", "hh:mm tt", CultureInfo.InvariantCulture);
            DateTime beforeMidnight = DateTime.ParseExact("11:59 PM", "hh:mm tt", CultureInfo.InvariantCulture);

            if ((DateTime.Compare(midnight, beerTime)) <= 0 &&
               DateTime.Compare(before, beerTime) > 0)
            {
                Console.WriteLine("Beer Time.");
            }

            if ((DateTime.Compare(after, beerTime)) <= 0 &&
               DateTime.Compare(beforeMidnight, beerTime) > 0)
            {
                Console.WriteLine("Beer Time.");
            }
            else
            {
                Console.WriteLine("Non-beer time.");
            }


           

        }
    }
}
