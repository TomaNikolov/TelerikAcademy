namespace AnimalHierarchy
{

    public class Cat : Animal
    {
        public Cat(string name, int age, Gender gender)
            : base(name, age, gender)
        {

        }

        public override void MakeSound()
        {
            System.Console.WriteLine("Mewyyy");
        }
    }
}
