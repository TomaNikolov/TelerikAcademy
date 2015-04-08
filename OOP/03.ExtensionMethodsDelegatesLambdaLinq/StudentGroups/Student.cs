namespace StudentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;

    public class Student
    {
        const int MinTelephoneDigit = 5;
        const string EmailValidation = "^[A-Z0-9._%+-]+@[A-Z0-9.-]+\\.[A-Z]{2,4}$.";
        const int MinGroupNumber = 1;
        const int MaxFroupNumber = 5;

        private string firstName;
        private string lastName;
        private string fN;
        private string tel;
        private string email;
        private int groupNumber;

        public Student(string firstName, string lastName, string fn, string tel, string email, List<Marks> marks, int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FN = fn;
            this.TelephoneNumber = tel;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
        }

        public IList<Marks> Marks { get; private set; }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First name can't be null or empty");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Last name can't be null or empty");
                }
                this.lastName = value;
            }
        }

        public string FN
        {
            get
            {
                return this.fN;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Faculty number can't be null or empty");
                }
                this.fN = value;
            }
        }

        public string TelephoneNumber
        {
            get
            {
                return this.tel;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Telephone number can't be null or empty");
                }
                if (value.Length < 5)
                {
                    throw new ArgumentException("Telephone number can't be less thsn five digit");
                }
                this.tel = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("E-mail can't be null or empty");
                }
                if (Regex.IsMatch(value, EmailValidation))
                {
                    throw new ArgumentException("E-mail is not valid");
                }
                this.email = value;
            }
        }

        public int GroupNumber
        {
            get
            {
                return this.groupNumber;
            }
            private set
            {
                if (value > 5 && value < 1)
                {
                    throw new IndexOutOfRangeException("Group number must be between one and four.");
                }
                this.groupNumber = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("First name: {0} ; Last name: {1} ; Faculty numbre: {3} \n", this.FirstName, this.LastName, this.FN);
            result.AppendFormat("Telephone number: {0} ; E-mail: {1} ; Group: {2} ;", this.TelephoneNumber, this.Email, this.groupNumber);
            result.AppendLine(string.Join(", ", this.Marks));
            return result.ToString();
        }
    }
}
