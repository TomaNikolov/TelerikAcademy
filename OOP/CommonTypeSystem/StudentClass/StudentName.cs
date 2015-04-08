namespace StudentClass
{
    using System;
    using System.Text;

    public class StudentName : IComparable<StudentName>
    {
        private const int equal = 0;

        public StudentName(string firstName, string middleName, string lastName)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
        }

        public StudentName(StudentName studentName)
            : this(studentName.FirstName, studentName.MiddleName, studentName.LastName)
        {

        }

        public string FirstName { get; private set; }
        public string MiddleName { get; private set; }
        public string LastName { get; private set; }

        //Problem 3. IComparable
        //Compare students by names (as first criteria, in lexicographic order)
        public int CompareTo(StudentName other)
        {
            int result = this.FirstName.CompareTo(other.FirstName);
            if (result == equal)
            {
                result = this.MiddleName.CompareTo(other.MiddleName);
            }
            if (result == equal)
            {
                result = this.LastName.CompareTo(other.LastName);
            }
            return result;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("{0} {1} {2}", this.FirstName, this.MiddleName, this.LastName);
            return result.ToString();
        }
    }
}
