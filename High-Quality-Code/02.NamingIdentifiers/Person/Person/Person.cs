namespace Person
{

    class Person
    {
        public Person()
        {

        }

        public Person(string name, int age, Gendre gender)
            :this()
        {
            this.Name = name;
            this.Age = age;
            this.Gendre = gender;
        }

        public Gendre Gendre { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public Person Configuration(int age)
        {
            var person = new Person();

            person.Age = age;
            int reminderOfAge = age % 2;

            person.Gendre = (Gendre) reminderOfAge;
            person.Name = ((Names) reminderOfAge).ToString();

            return person;
        }

        public override string ToString()
        {
            return string.Format("Name: {0}, Gendre: {1}, Age: {2}", this.Name, this.Gendre, this.Age);
        }
    }
}
