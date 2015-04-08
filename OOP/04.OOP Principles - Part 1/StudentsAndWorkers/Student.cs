namespace StudentsAndWorkers
{
    using System;

    public class Student : Human
    {
        private const int maxGdare = 6;
        private const int minGrade = 2;

        private int grade;

        public Student(string firsName, string lastName, int grade)
            :base(firsName, lastName)
        {
            this.Grade = grade;
        }

        public int Grade
        {
            get
            {
                return this.grade;
            }
            set
            {
                if(value > maxGdare || value < minGrade)
                {
                    throw new FormatException( string.Format("Grade must be in interval {0} - {1}", minGrade, maxGdare));
                }
                this.grade = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + " Grade: " + this.Grade;
        }
    }
}
