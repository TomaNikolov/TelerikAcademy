namespace StudentClass
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Student : ICloneable, IComparable<Student>
    {
        public Student(StudentName studentName, string ssn, List<Course> courses, StudentInfo studentInfo)
        {
            this.StudentName = studentName;
            this.SSN = ssn;
            this.Courses = courses;
            this.StudentInfo = studentInfo;
        }

        public Student(StudentName studentName, string ssn)
            : this(studentName, ssn, new List<Course>(), new StudentInfo())
        {

        }

        public Student(StudentName studentName, string ssn, StudentInfo studentInfo)
            : this(studentName, ssn, new List<Course>(), studentInfo)
        {
            
        }

        public Student(StudentName studentName, string ssn, StudentInfo studentInfo, Specialties specialty, Faculties faculty, Universities university)
            : this(studentName, ssn, studentInfo)
        {
            this.Specialty = specialty;
            this.Faculty = faculty;
            this.University = university;
        }

        public StudentName StudentName { get; private set; }
        public string SSN { get; set; }
        public StudentInfo StudentInfo { get; private set; }
        public IList<Course> Courses { get; private set; }
        public Specialties? Specialty { get; private set; }
        public Faculties? Faculty { get; private set; }
        public Universities? University { get; private set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(this.StudentName.ToString());
            result.AppendFormat("SSN: {0}; \n", this.SSN);
            result.AppendLine(this.StudentInfo.ToString());
            result.AppendFormat("University: {0}; Faculty: {1}; Specialty: {2} \n", this.University, this.Faculty, this.Specialty);
            result.AppendLine("Courses: " + string.Join(", ", this.Courses));
            return result.ToString();
        }

        public override bool Equals(object obj)
        {
            Student student = (obj as Student);

            if (student == null)
            {
                return false;
            }
            if (!Object.Equals(this.SSN, student.SSN))
            {
                return false;
            }
            return true;
        }

        public override int GetHashCode()
        {
            return this.StudentName.GetHashCode() ^ this.StudentInfo.GetHashCode() ^ this.SSN.GetHashCode();
        }

        public static bool operator ==(Student firstStudent, Student secondStudent)
        {
            return firstStudent.Equals(secondStudent);
        }

        public static bool operator !=(Student firstStudent, Student secondStudent)
        {
            return !(firstStudent.Equals(secondStudent));
        }

        //Problem 2. IClonable
        //Add implementations of the ICloneable interface. 
        //The Clone() method should deeply copy all object's fields 
        //into a new object of type Student.
        public object Clone()
        {
            var result = this.MemberwiseClone();
            (result as Student).StudentName = new StudentName(this.StudentName);
            (result as Student).StudentInfo = new StudentInfo(this.StudentInfo);
            (result as Student).Courses = new List<Course>(this.Courses);
            return result;
        }
        //Problem 3. IComparable
        //Compare by social security number (as second criteria, in increasing order).
        public int CompareTo(Student other)
        {
            int result = this.StudentName.CompareTo(other.StudentName);
            if (result == 0)
            {
                result = this.SSN.CompareTo(other.SSN);
            }
            return result;
        }
    }
}
