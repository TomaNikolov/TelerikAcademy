namespace SchoolClasses
{
    using System.Text;

    public class Discipline : IComments
    {
        public Discipline(string name, int numberOfLectures, int numberOfExercises)
        {
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercises = numberOfExercises;
        }

        public string Comment { get; set; }
        public string Name { get; private set; }
        public int NumberOfLectures { get; private set; }
        public int NumberOfExercises { get; private set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("Discipline name: {0}; Number of Lecture: {1}; Number of exercises: {2};", this.Name, this.NumberOfLectures, this.NumberOfExercises);
            result.AppendLine();
            result.AppendLine("Discipline Comment: " + this.Comment);
            return result.ToString();
        }
    }
}
