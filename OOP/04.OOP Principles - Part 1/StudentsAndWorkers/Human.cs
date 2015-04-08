namespace StudentsAndWorkers
{
    using System.Text;

    public abstract class Human
    {
        private string firsName;
        private string lastName;

        public Human(string firsName, string lastName)
        {
            this.FirstName = firsName;
            this.lastName = lastName;
        }

        public string FirstName
        {
            get
            {
                return this.firsName;
            }
            private set
            {
                this.firsName = value;
            }
        }

        public string LastaName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                this.lastName = value;
            }
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("{0} {1}", this.FirstName, this.LastaName);
            return result.ToString();
        }
    }
}
