namespace StudentGroups
{
    using System;
    using System.Text;

    public class Group
    {
        const int FirstGroup = 1;

        private int groupNumber;

        public Group(int groupNumber, string departmentsName)
        {
            this.GroupNumber = groupNumber;
            this.DepartmentName = departmentsName;
        }

        public string DepartmentName { get; private set; }

        public int GroupNumber
        {
            get
            {
                return this.groupNumber;
            }
            private set
            {
                if (value < FirstGroup)
                {
                    throw new ArgumentException("Group number must be bigger than zero.");
                }
                this.groupNumber = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Groupe number: {0} ; Department name: {1} ;", this.GroupNumber, this.DepartmentName);
        }
    }
}
