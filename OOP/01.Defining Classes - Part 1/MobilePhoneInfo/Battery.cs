namespace MobilePhoneInfo
{
    using System;
    using System.Text;

    public class Battery
    {
        private const int minLenghtOfName = 2;

        private string model;
        private double? hoursIdle;
        private double? hoursTalk;
        private BatteryType batteryType;

        public Battery()
        {

        }

        public Battery(string model, double hoursIdle, double hoursTalk, BatteryType batteryType)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.BatteryType = batteryType;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            private set
            {
                if (value.Length < minLenghtOfName)
                {
                    throw new ArgumentException();
                }
                this.model = value;
            }
        }

        public double? HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            private set
            {
                if (value < 0 || value > double.MaxValue)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.hoursIdle = value;
            }
        }

        public double? HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            private set
            {
                if (value < 0 || value > double.MaxValue)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.hoursTalk = value;
            }
        }

        public BatteryType BatteryType
        {
            get
            {
                return this.batteryType;
            }
            private set
            {
                this.batteryType = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("Model: {0}; Battery type: {1}; \n", this.Model, this.BatteryType);
            result.AppendFormat("Hours talk: {0}; Hours idle: {1};", this.HoursTalk, this.HoursIdle);
            return result.ToString();
        }
    }
}
