namespace Naming_Identifiers
{
    using System;

    public class Printer
    {
        private const int MAX_COUNT = 6;

        public class BoolPrint
        {
            public BoolPrint()
            {

            }

            public void Print(bool value)
            {
                Console.WriteLine(value);
            }
        }
    }
}
