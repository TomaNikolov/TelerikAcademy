namespace SchoolClasses
{
    using System.Collections.Generic;
    using System.Text;

    public class School
    {
        public School()
        {
            this.Classes = new List<Class>();
        }

        public List<Class> Classes { get; private set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine("***List of Classes: ***");
            foreach (var classes in this.Classes)
            {
                result.AppendLine(classes.ToString());
            }
            return result.ToString();
        }
    }
}
