namespace Person
{
    using System.Text;

    public class Person
    {
        public Person(string name, int? age = null)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; private set; }
        public int? Age { get; private set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("Name: {0}; Age: {1};", this.Name, (this.Age != null)? this.Age.ToString() : "Age is not specified");
            return result.ToString();
        }
    }
}
