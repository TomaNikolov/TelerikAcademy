namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class People : IComments
    {
        private string name;

        public People(string name)
        {
            this.Name = name;

        }

        public string Comment { get; set; }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (value.Length < 2 || value == null)
                {
                    throw new FormatException("Name must be longer than 2 symbols");
                }
                this.name = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Name: {0};", this.name);
        }
    }
}
