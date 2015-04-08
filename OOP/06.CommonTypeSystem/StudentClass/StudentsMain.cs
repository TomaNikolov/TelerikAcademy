namespace StudentClass
{
    using System;
    using System.Collections.Generic;

    public class StudentsMain
    {
        public static void Main()
        {
            Student firstStudent = new Student(new StudentName("Pesho", "PeShev", "Peshev"), "886764324");
            firstStudent.Courses.Add(new Course("OOP"));
            //Clone first student
            Student secondStudent = (firstStudent.Clone() as Student);
            //Because is a deep clone we can change course only of the clone, without make any changes on the first student.
            secondStudent.Courses[0] = new Course("JavaScript");
            //Both students are with the same names, if change SSN, this will affect sorting in array
            secondStudent.SSN = "886764325";
            List<Student> studentList = new List<Student>();
            studentList.Add(firstStudent);
            studentList.Add(secondStudent);
            studentList.Sort();
            //Print students
            foreach (var student in studentList)
            {
                Console.WriteLine(student);
            }
        }
    }
}
