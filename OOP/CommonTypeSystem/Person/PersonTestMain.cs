namespace Person
{
    using System;

    public class PersonTestMain
    {
        public static void Main()
        {
            Person personWithAge = new Person("Pesho", 100);
            Person personWithoutAge = new Person("Gosho");
            Console.WriteLine(personWithAge);
            Console.WriteLine(personWithoutAge);
        }
    }
}
