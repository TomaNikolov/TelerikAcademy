namespace StudentsAndWorkers
{
    using System;

    public class Worker : Human
    {
        private const int min = 0;
        private const int workDayInWeek = 5;

        private double weekSalary;
        private int workHoursPerDay;

        public Worker(string firstName, string lastName, double weekSalary, int workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public double WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            private set
            {
                if (value < min)
                {
                    throw new FormatException("Week Salary can not be negative!");
                }
                this.weekSalary = value;
            }
        }

        public int WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            private set
            {
                if (value < min)
                {
                    throw new FormatException("Work  hours per day, can not be negative!");
                }
                this.workHoursPerDay = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + " Money per hour: " + MoneyPerHour();
        }
        /// <summary>
        /// Returns money earned by hour by the worker
        /// </summary>
        /// <returns></returns>
        public double MoneyPerHour()
        {
            double result = this.WeekSalary / this.workHoursPerDay * workHoursPerDay;
            return result;
        }
    }
}
