using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace CurrentDateAndTime
{
    class Program
    {
        static void Main()
        {
            Timer second = new Timer(1000);

            Console.WriteLine(DateTime.Now);

            second.Elapsed += OnTimedEvent;
            second.Start();

            Console.ReadLine();

        }
        private static void OnTimedEvent(Object sourse, ElapsedEventArgs e)
        {
            Console.Clear();
            Console.WriteLine(DateTime.Now);

        }
    }
}
