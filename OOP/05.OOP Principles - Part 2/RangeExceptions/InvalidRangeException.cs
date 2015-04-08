namespace RangeExceptions
{
    using System;
    using System.Text;

    public class InvalidRangeException<T> : ApplicationException
    {
        public InvalidRangeException(string msg, T start, T end, Exception causeException)
            : this(msg, causeException)
        {
            this.Start = start;
            this.End = end;
        }

        public InvalidRangeException(string msg, T start, T end)
            : this(msg, start, end, null)
        {
            
        }

        public InvalidRangeException(string msg, Exception causeException)
            : base(msg, causeException)
        {

        }
        public T Start { get; private set; }
        public T End { get; private set; }

        public override string Message
        {
            get
            {
                string result = string.Format("{0} [{1}...{2}]", base.Message, this.Start.ToString() ?? "", this.End.ToString() ?? "");
                return result;
            }
        }
    }
}
