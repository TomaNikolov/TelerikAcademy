namespace StudentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StudetnGroupsMain
    {
        static Student[] students = new Student[]
        {
            new Student( "Pesho", "Goshov", "000005", "02000001", "pesho@av.bg",
            new List<Marks>{Marks.Excellent, Marks.VeryGood, Marks.Good},1 ),
            new Student( "Mitko", "Goshov", "000006", "02000002", "Mitko@abv.bg",
            new List<Marks>{Marks.Excellent, Marks.Good, Marks.Good},2),
            new Student( "Gosho", "Goshov", "000006", "02000003", "gosho@abv.bg",
            new List<Marks>{Marks.Poor, Marks.Poor, Marks.Good},4),
            new Student( "Vankata", "Goshov", "000005", "02000010", "vankata@abv.bg",
            new List<Marks>{Marks.Excellent, Marks.VeryGood, Marks.Good},3),
            new Student( "BaiIvan", "Mitkov", "000007", "03200001", "BaiIvan@abv.bg",
            new List<Marks>{Marks.Excellent, Marks.VeryGood, Marks.Good},1),
            new Student( "Roskata", "BaiIvanov", "000009", "03200002", "roskata@gmail.com",
            new List<Marks>{Marks.Good, Marks.Good, Marks.Good},2),
            new Student( "Hristo", "Georgiev", "000007", "03200004", "hristo@gmail.com",
            new List<Marks>{Marks.Excellent, Marks.Excellent, Marks.Excellent}, 1)
        };

        static Group[] groupName = new Group[]
        {
             new Group(1, "Mathematics"),
             new Group(2, "Physics"),
            new Group(4, "Informatics"),
              new Group(3, "Biology"),
        };

        public static void Main()
        {
            //Problem 9
            //Use LINQ query. Order the students by FirstName.

            var orderByFirstNameLinq = from x in students
                                       orderby x.FirstName
                                       select x;

            //Problem 10. Student groups extensions
            //mplement the previous using the same query expressed with extension methods.

            var orderByFirstNameLambda = students.OrderBy(x => x.FirstName);

            //Problem 11. Extract students by email
            //Extract all students that have email in abv.bg.
            //Use string methods and LINQ.

            var allStudentMailInAbv = from x in students
                                      where x.Email.Contains("abv.bg")
                                      select x;

            //Problem 12. Extract students by phone
            //Extract all students with phones in Sofia.
            //Use LINQ.

            var allStudentWithPhoneInSofia = from x in students
                                             where x.TelephoneNumber.StartsWith("02")
                                             select x;

            //Problem 13. Extract students by marks
            //Select all students that have at least one mark Excellent (6) into a new anonymous class that has properties – FullName and Marks.
            //Use LINQ.

            var AtLeastoneExselentMark = from x in students
                                         where x.Marks.Contains(Marks.Excellent)
                                         select new { FullName = x.FirstName + " " + x.LastName, Marks = x.Marks };

            //Problem 14. Extract students with two marks
            //Write down a similar program that extracts the students with exactly two marks "2".
            //Use extension methods.

            var exactlyTwoMarksPoor = students.Where(x => x.Marks.Count(y => y == Marks.Poor) == 2)
                                                                 .Select(x => new 
                                                                 { 
                                                                     FullName = x.FirstName + " " + x.LastName,
                                                                     Marks = x.Marks 
                                                                 });

            //Problem 15. Extract marks
            //Extract all Marks of the students that enrolled in 2006. 
            //(The students from 2006 have 06 as their 5-th and 6-th digit in the FN).

            var AllMarksEnrolledIn06 = students.Where(x => x.FN[4] == '0' && x.FN[5] == '6')
                                               .SelectMany(x => x.Marks);

            //Problem 16.* Groups
            // Extract all students from "Mathematics" department.
            //Use the Join operator.

            var studentsFromMathrmatiksDepartment = students.Where(x => x.GroupNumber == 1)
                                                            .Join(groupName, x => x.GroupNumber, y => y.GroupNumber,
                                                             (x, y) => new
                                                             {
                                                                 Name = x.FirstName + " " + x.LastName,
                                                                 Department = y.DepartmentName 
                                                             });

            //Problem 18. Grouped by GroupName
            //Create a program that extracts all students grouped by GroupName and then prints them to the console.
            //Use LINQ.

            var studentsGroupedByDepartmentLinq = from x in students
                                                  orderby x.GroupNumber
                                                  join y in groupName
                                                  on x.GroupNumber equals y.GroupNumber
                                                  select new { Name = x.FirstName + " " + x.LastName, Department = y.DepartmentName };

            Print(studentsGroupedByDepartmentLinq);

            //Problem 19. Grouped by GroupName extensions
            //Rewrite the previous using extension methods.

            var studentsGroupedByDepartmentNameLmabda = students.OrderBy(x => x.GroupNumber)
                                                                .Join(groupName, x => x.GroupNumber, y => y.GroupNumber,
                                                                (x, y) => new
                                                                { 
                                                                    Name = x.FirstName + " " + x.LastName,
                                                                    Department = y.DepartmentName 
                                                                });
            
          //  Print(studentsGroupedByDepartmentNameLmabda);
        }

        public static void Print<T>(IEnumerable<T> collection)
        {
            foreach (var elements in collection)
            {
                Console.WriteLine(elements);
            }
        }
    }
}
