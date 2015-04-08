namespace AnimalHierarchy
{
    using System.Collections.Generic;
    using System.Linq;

    public abstract class Animal : ISound
    {
        public Animal (string name, int age, Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name { get; private set; }
        public int Age { get; private set; }
        public Gender Gender { get; private set; }

        public abstract void MakeSound();

        public static double AverageAgeOfEachKind<T>(IEnumerable<Animal> collection)
            where T : Animal
        {
            var result = collection.OfType<T>().Average(x => x.Age);
            return result;
        }
    }
}
