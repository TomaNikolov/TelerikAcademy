namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AnimalHierarchyMain
    {
        static void Main()
        {
            //Create arrays of different kinds of animals
            var arrayOfAnimals = new Animal[]
            {
               new Dog("Rex", 3, Gender.Male),
               new Dog("Sharo", 4, Gender.Male),
               new Dog("Balkan", 5, Gender.Male),
               new Dog("Vancheto", 1, Gender.Female),
               new Frog("Pesho", 1, Gender.Male),
               new Frog("Mitko", 1, Gender.Female),
               new TomCat("Machko", 5),
               new TomCat("Pisko", 8),
               new Kitten("Machka", 2),
               new Kitten("Piska", 10),
            };
            //calculate the average age of each kind of animal using a static method (you may use LINQ).
            var averageCatAge = Animal.AverageAgeOfEachKind<Cat>(arrayOfAnimals);
            var averageDogAge = Animal.AverageAgeOfEachKind<Dog>(arrayOfAnimals);
            var averageFrogAge = Animal.AverageAgeOfEachKind<Frog>(arrayOfAnimals);

            Console.WriteLine("Cat Average: {0}; Dog Average: {1}; Frog Average: {2};", averageCatAge, averageDogAge, averageFrogAge);
        }
    } 
}
