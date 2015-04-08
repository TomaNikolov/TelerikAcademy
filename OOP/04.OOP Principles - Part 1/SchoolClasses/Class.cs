namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Class : IComments
    {
        private string textIdentifier;

        public Class(string textIdentifier)
        {
            this.TextIdentifier = textIdentifier;
            ListOfTeachers = new List<Teacher>();
            ListOfStudents = new List<Student>();
        }

        public string Comment { get; set; }
        public List<Teacher> ListOfTeachers { get; private set; }
        public List<Student> ListOfStudents { get; private set; }

        public string TextIdentifier
        {
            get
            {
                return this.textIdentifier;
            }
            private set
            {
                if (value == null)
                {
                    throw new FormatException("Identifier can not be null!");
                }
                this.textIdentifier = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine("Class identifier: " + this.TextIdentifier);
            result.AppendLine("***List of Teachers: ***");
            foreach (var teacher in this.ListOfTeachers)
            {
                result.Append(teacher.ToString());
            }
            result.AppendLine("***List of Students: ***");
            foreach (var student in this.ListOfStudents)
            {
                result.Append(student.ToString());
            }
            result.AppendLine("Class comment: " + this.Comment);
            return result.ToString();
        }
    }
}
