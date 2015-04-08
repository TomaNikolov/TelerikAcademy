namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Student : People
    {
        private int uniqueClassNumber;

        public Student(string name, int uniqueClassNumber)
            : base(name)
        {
            this.UniqueClassNumber = uniqueClassNumber;
        }

        public int UniqueClassNumber
        {
            get
            {
                return this.uniqueClassNumber;
            }
            private set
            {
                this.uniqueClassNumber = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(base.ToString() + string.Format(" Class number: {0};", this.uniqueClassNumber));
            result.AppendLine("Student comment: " + this.Comment);
            return result.ToString();
        }

    }
}
