﻿namespace AnimalHierarchy
{

    public class Dog : Animal
    {
        public Dog(string name, int age, Gender gender)
            : base(name, age, gender)
        {

        }

        public override void MakeSound()
        {
            System.Console.WriteLine("Bayyyy");
        }
    }
}
