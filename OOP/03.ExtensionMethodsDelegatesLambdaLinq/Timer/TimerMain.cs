
//Problem 7. Timer
//Using delegates write a class Timer that can execute certain
//method at each t seconds.

namespace Timer
{
    using System;

    public class TimerMain
    {
        public static void Main()
        {
            Timer timer = new Timer(1);
            //Action with no arguments
            timer.InitialiseMethod = () => Chronometer();
            timer.Start();
        }

        public static void Chronometer()
        {
            Console.Clear();
            Console.WriteLine(DateTime.Now);
        }
    }
}
