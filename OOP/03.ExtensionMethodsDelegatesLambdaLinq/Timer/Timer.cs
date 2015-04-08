namespace Timer
{
    using System;
    using System.Threading;

    public class Timer
    {
        private const int OneSecondInMiliSec = 1000;
        private int interval;

        public Timer(int interval)
        {
            this.Interval = interval;
        }

        public Action InitialiseMethod { get; set; }

        public int Interval
        {
            get
            {
                return this.interval;
            }
            private set
            {
                if(value <= 0)
                {
                    throw new ArgumentException("Timer cannot be less than 1 second");
                }
                this.interval = value * OneSecondInMiliSec;
            }
        }

        public void Start()
        {
            while (true)
            {
                this.InitialiseMethod();
                Thread.Sleep(this.interval);
            }
        }
    }
}
