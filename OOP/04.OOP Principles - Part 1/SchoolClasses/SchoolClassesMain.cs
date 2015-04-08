namespace SchoolClasses
{
    using System;

    public class SchoolClassesMain
    {
        static void Main()
        {
            var oop = new Discipline("OOP", 2, 6);
            var cSharp2 = new Discipline("C#2", 2, 8);
            var baiPesho = new Teacher("Bai Pesho");
            var peshoStudent = new Student("Pesho", 1);
            var mitkoStudent = new Student("Mitko", 1);
            var firstClass = new Class("1");
            var school = new School();
            baiPesho.ListOfDiscipline.Add(oop);
            baiPesho.ListOfDiscipline.Add(cSharp2);
            firstClass.ListOfTeachers.Add(baiPesho);
            firstClass.ListOfStudents.Add(peshoStudent);
            firstClass.ListOfStudents.Add(mitkoStudent);
            school.Classes.Add(firstClass);
            //Print Scool
            Console.WriteLine(school);

        }
    }
}
