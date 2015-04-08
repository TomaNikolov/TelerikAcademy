namespace BankAccounts
{
    public class MortgageAccount : Account
    {
        private const int minMonthsForCompany = 12;
        private const int minMounhsForIndividuals = 6;
        private const int halfOfTheInteset = 2;

        public MortgageAccount(Customers customer, decimal ballance, double interestRate)
            : base(customer, ballance, interestRate)
        {

        }

        public override double InterestAmount(int months)
        {
            if (this.Customer == Customers.Companies)
            {
                if (months < minMonthsForCompany)
                {
                    return (this.InterestRate * months) / halfOfTheInteset;
                }
                else
                {
                    return this.InterestRate * months;
                }
            }
            else
            {
                if (months < minMounhsForIndividuals)
                {
                    return 0;
                }
                else
                {
                    return this.InterestRate * months;
                }
            }
        }
    }
}
