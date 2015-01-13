using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeAfterTenYears
{
    class Program
    {
        static void Main()
        {
            Console.Write("Please enter birthday date: ");
            DateTime birthday = DateTime.Parse(Console.ReadLine());

            DateTime dateNow = DateTime.Now;
            System.TimeSpan age = dateNow.Subtract(birthday);

            int curentAge = (int)age.TotalDays / 365;

            Console.WriteLine("You are {0} years old.", curentAge);
            Console.WriteLine("After ten years you will be {0} years old.", curentAge + 10);
            
        }
    }
}
