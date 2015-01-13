using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmplayeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "John";
            string lastName = "Smith";
            byte age = 58;
            bool isMale = true;
            long idNumber = 83061112507;
            int emplayeeNumber = 27459998;
            
            Console.WriteLine("First name: {0}", firstName);
            Console.WriteLine("Last name: {0}", lastName);
            Console.WriteLine("Employee  age: {0}", age);
            Console.WriteLine("Gender: {0}", Gender(isMale));
            Console.WriteLine("Personal ID number: {0}", idNumber);
            Console.WriteLine("Unique employee number: {0}", emplayeeNumber);
        }
        public static string Gender(bool isMale)
        {
            
            if (isMale == true)
            {
                return "Male";
            }
            else
            {
                return  "Female";
            }
           
        }
    }
}
