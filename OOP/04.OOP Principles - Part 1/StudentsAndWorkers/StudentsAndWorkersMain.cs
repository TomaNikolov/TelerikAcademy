namespace StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StudentsAndWorkersMain
    {
        static void Main()
        {
            var studentList = new List<Student>
            {
               new Student("Pesho", "Peshev", 6),
               new Student("Mitko", "Mitkov", 5),
               new Student("Ivan", "Ivanov", 4),
               new Student("Pesho", "Mitkov", 3),
               new Student("Mitko", "Peshev", 2),
               new Student("Ivan", "Peshev", 3),
               new Student("Pesho", "Ivanov", 4),
               new Student("Mitko", "Ivanov", 5),
               new Student("Ivan", "Mitkov", 6),
               new Student("Mladen", "Mitkov", 6),
            };

            var workerList = new List<Worker>
            {
               new Worker("Pesho", "Peshev", 120, 8),
               new Worker("Mitko", "Mitkov", 240, 5),
               new Worker("Ivan", "Ivanov", 320, 4),
               new Worker("Pesho", "Mitkov", 432, 3),
               new Worker("Mitko", "Peshev", 20, 2),
               new Worker("Ivan", "Peshev", 518, 3),
               new Worker("Pesho", "Ivanov", 222, 4),
               new Worker("Mitko", "Ivanov", 753, 5),
               new Worker("Ivan", "Mitkov", 226, 6),
               new Worker("Mladen", "Mitkov", 783, 9),
            };
            //sort by grade in ascending order
            var sortedByGrade = studentList.OrderBy(x => x.Grade);
            Print(sortedByGrade);
            //sort by money per hour in descending order
            var sortedByMoneyPerHour = workerList.OrderByDescending(x => x.MoneyPerHour());
            Print(sortedByMoneyPerHour);
            //Merge the lists and sort them by first name and last name.
            var mergedList = studentList.Cast<Human>().Union(workerList.Cast<Human>())
                         .ToList().OrderBy(x => x.FirstName).ThenBy(x => x.LastaName);

            Print(mergedList);
        }
        //Print collection
        public static void Print<T>(IEnumerable<T> collection)
        {
            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }
        }
    }
}
