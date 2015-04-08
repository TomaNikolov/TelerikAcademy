namespace RangeExceptions
{
    using System;
    using System.Globalization;

    class InvalidRangeExceptionTest
    {
        static void Main()
        {
            int min = 1;
            int max = 100;
            Console.WriteLine("Enter a number in interval [{0}..{1}]", min, max);
            int x = int.Parse(Console.ReadLine());

            if (x < min || x> max)
            {
                throw new InvalidRangeException<int>("Number must be in interval", min, max);
            }

            DateTime mindate = new DateTime(1980, 1, 1);
            DateTime maxdate = new DateTime(2013, 12, 31);
            Console.WriteLine("Enter a date in interval [{0}..{1}] in format \"dd.MM.yyyy\"", mindate.ToString("dd.MM.yyyy"), maxdate.ToString("dd.MM.yyyy"));
            string inputDate = Console.ReadLine();
            DateTime date =  DateTime.ParseExact(inputDate, "dd.MM.yyyy", CultureInfo.InvariantCulture);
           
            if (date < mindate || date > maxdate)
            {
                throw new InvalidRangeException<DateTime>("Number must be in interval", mindate, maxdate);
            }
        }
    }
}
