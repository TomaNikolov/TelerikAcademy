namespace MobilePhoneInfo
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class GSM
    {
        private const int minLenghtOfName = 2;
        private const int minute = 60;

        // Problem 6 Iphone4s
        public static Battery iPhoneBattery = new Battery("A1332", 20, 2, BatteryType.LiIon);
        public static Display iPhoneDisplay = new Display(3.5, 16000000);
        private static GSM iPhone4S = new GSM("Apple", "IPhone4S", 999, "Pesho", iPhoneBattery, iPhoneDisplay); //7

        private string model;
        private string manufacturer;
        private double? price;
        private string owner;
        private Battery battery;
        private Display display;
        private List<Call> calls;

        //Problem 2 Constructors
        public GSM(string manufacturer, string model)
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.Calls = new List<Call>();
        }

        public GSM(string manufacturer, string model, double price, string owner, Battery battery, Display display)
            : this(manufacturer, model)
        {
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
            List<Call> calls = new List<Call>();
        }

        public static GSM IPhone4S
        {
            get
            {
                return iPhone4S;
            }
            private set
            {
                iPhone4S = value;
            }
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
                    throw new ArgumentOutOfRangeException();
                }
                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            private set
            {
                if (value.Length < minLenghtOfName)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.manufacturer = value;
            }
        }

        public double? Price
        {
            get
            {
                return this.price;
            }
            private set
            {
                if (value < 0 || value > double.MaxValue)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.price = value;
            }
        }
        public string Owner
        {
            get
            {
                return this.owner;
            }
            private set
            {
                if (value.Length < minLenghtOfName)
                {
                    throw new ArgumentException();
                }
                this.owner = value;
            }
        }

        public Battery Battery
        {
            get
            {
                return this.battery;
            }
            private set
            {
                this.battery = value;
            }
        }

        public Display Display
        {
            get
            {
                return this.display;
            }
            private set
            {
                this.display = value;
            }
        }

        public List<Call> Calls
        {
            get
            {
                return this.calls;
            }
            private set
            {
                this.calls = value;
            }
        }

        // Problem 4. ToString
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("Manufacturer: {0}; Model: {1}\n", this.Manufacturer, this.Model);
            result.AppendFormat("Price: {0}; Owner: {1}; \n", this.Price, this.Owner);
            result.AppendLine("----Battery----");
            result.AppendFormat("{0} \n", this.Battery.ToString());
            result.AppendLine("----Display----");
            result.AppendFormat("{0}", this.Display.ToString());
            return result.ToString();
        }

        /// <summary>
        /// Add new call in phone history 
        /// </summary>
        /// <param name="call"></param>
        public void AddCal(Call call)
        {
            this.Calls.Add(call);
        }

        /// <summary>
        /// Remove Call in a position count from 0.
        /// </summary>
        /// <param name="numberOfCall"></param>
        public void DeleteCall(int numberOfCall)
        {
            if (numberOfCall < 0 || numberOfCall >= Calls.Count)
            {
                throw new ArgumentOutOfRangeException();
            }
            this.Calls.RemoveAt(numberOfCall);
        }

        /// <summary>
        /// Clear call history 
        /// </summary>
        public void ClearCallHistory()
        {
            Calls.Clear();
        }
        /// <summary>
        /// Calculate total price of all calls.
        /// </summary>
        /// <param name="price"></param>
        /// <returns></returns>
        public double CallPrice(double price)
        {
            double result = 0;
            foreach (var call in Calls)
            {
                result += (call.DurationInSecond / minute) * price;
            }
            return result;
        }
    }
}
