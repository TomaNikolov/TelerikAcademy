using System;

namespace BankAccountData
{
    class Program
    {
        static void Main()
        {
            string firstName = "Ivan";
            string middleName = "Ivanov";
            string lastName = "Ivanov";

            decimal balance = 20;

            string bankName = "KTB";
            string iban = "GB29 NWBK 6016 1331 9268 19";
            long firstCreditCard = 5000005099991234;
            long secondCreditCard = 5000005099991235;
            long thirdCreditCard = 5000005099991236;

            Console.WriteLine("Names: " + firstName + " " + middleName + " " + lastName);
            Console.WriteLine("Balace: " + balance + " lv");
            Console.WriteLine("Bank name: " + bankName);
            Console.WriteLine("IBAN: " + iban);
            Console.WriteLine("First credit card: " + firstCreditCard);
            Console.WriteLine("Second credit card: " + secondCreditCard);
            Console.WriteLine("Third credit card: " + thirdCreditCard);


        }
    }
}
