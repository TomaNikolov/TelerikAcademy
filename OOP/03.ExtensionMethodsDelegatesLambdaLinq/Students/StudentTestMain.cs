using System;
using System.Collections.Generic;
using System.Linq;
namespace Students
{
    using System.Collections.Generic;
    using System.Linq;

    public class StudentTestMain
    {
        public static void Main()
        {
            var studentList = new List<Student>
            {
                new Student("Pesho", "Ivanov", 23),
                new Student("Gosho", "Peshov", 73),
                new Student("Vankata", "Goshov", 33),
                new Student("Mitko", "Ivanov", 2),
                new Student("Gosho", "Ivanov", 18),
                new Student("Pesho", "Mitkov", 24),
                new Student("BaiIvan", "Peshov", 100),
            };

            //Problem 3. First before last
            //Write a method that from a given array of students finds all students
            //    whose first name is before its last name alphabetically.
            //Use LINQ query operators.

            //Linq
            var firstNameBeforeLastLinq = from x in studentList
                                          where x.FirstName.CompareTo(x.LastName) < 0
                                          select x;
            //  Print(firstNameBeforeLastLinq);

            //lambda expressions
            var firstNameBeforeLastLambda = studentList.Select(x => x.FirstName
                                                       .CompareTo(x.LastName) < 0);

            //Problem 4. Age range
            //  Write a LINQ query that finds the first name and last
            //name of all students with age between 18 and 24.

            //Linq
            var firstAndLastNameAgeBetween = from s in studentList
                                             where s.Age <= 24 && s.Age >= 18
                                             select new { FirstName = s.FirstName, LastName = s.LastName };
            //  Print(firstAndLastNameAgeBetween);

            //lambda expressions
            var firstAndLastNameAgeBetweenLambda = studentList.Where(x => x.Age <= 24 && x.Age >= 18)
                                                              .Select(x => new 
                                                              {
                                                                  Firstname = x.FirstName,
                                                                  LastName = x.LastName 
                                                              });

            //Print(firstAndLastNameAgeBetweenLambda);


            //Problem 5. Order students
            //Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order.
            //Rewrite the same with LINQ.

            //lambda expressions
            var OrderStudentLambda = studentList.OrderByDescending(x => x.FirstName)
                                                .ThenByDescending(x => x.LastName);

            // Print(OrderStudentLambda);

            //Linq
            var OrderStudentLinq = from x in studentList
                                   orderby x.FirstName descending,
                                   x.LastName descending
                                   select x;
        }

        public static void Print<T>(IEnumerable<T> collection)
        {
            foreach (var element in collection)
            {
                Console.WriteLine(element.ToString());
            }
        }
    }
}
