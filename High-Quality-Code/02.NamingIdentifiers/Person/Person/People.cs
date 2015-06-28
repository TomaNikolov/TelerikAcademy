namespace Person
{
    using System;

    public class People
    {
       public static void Main()
       {
           var male = new Person();
           var female = new Person();
           male = male.Configuration(20);
           female = female.Configuration(21);

           Console.WriteLine(male);
           Console.WriteLine(female);
       }
    }
}
