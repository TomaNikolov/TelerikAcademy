namespace SchoolClasses
{
    using System.Collections.Generic;
    using System.Text;

    public class Teacher : People
    {
        public Teacher(string name)
            : base(name)
        {
            this.ListOfDiscipline = new List<Discipline>();
        }
        public List<Discipline> ListOfDiscipline { get; set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(base.ToString());
            foreach (var discipline in ListOfDiscipline)
            {
                result.Append(discipline.ToString());
            }
            result.AppendLine("Teacher Comment: " + this.Comment);
            return result.ToString();
        }
    }
}
