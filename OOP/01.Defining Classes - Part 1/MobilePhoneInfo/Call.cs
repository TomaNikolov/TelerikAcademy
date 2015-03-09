namespace MobilePhoneInfo
{
    using System;
    using System.Text;

    public class Call
    {
        private const int minPhoneNumberLenght = 8;
        private const int minCallDuration = 0;

        private string date;
        private string time;
        private string dailedPhoneNumber;
        private long durationInSecond;


        public Call(string dailedPhoneNumber, long durationInSecond)
        {
            this.DailedPhoneNumber = dailedPhoneNumber;
            this.DurationInSecond = durationInSecond;
            this.Date = DateTime.Now.ToString("D");
            this.Time = DateTime.Now.ToString("HH:mm:ss");
        }

        public string DailedPhoneNumber
        {
            get
            {
                return this.dailedPhoneNumber;
            }
            private set
            {
               if(value.Length < minPhoneNumberLenght)
               {
                   throw new ArgumentOutOfRangeException();
               }
               this.dailedPhoneNumber = value;
            }
        }

        public long DurationInSecond
        {
            get
            {
                return this.durationInSecond;
            }
            private set
            {
                if (value < minCallDuration)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.durationInSecond = value;
            }
        }

        public string Date
        {
            get
            {
                return this.date;
            }
            private set
            {
                this.date = value;
            }
        }
        public string Time
        {
            get
            {
                return this.time;
            }
            private set
            {
                this.time = value;
            }
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("Date: {0}; Time: {1}\n", this.Date, this.Time);
            result.AppendFormat("Phone Number: {0}; Duration: {1}", this.DailedPhoneNumber, this.DurationInSecond);
            return result.ToString();
        }
    }
}
