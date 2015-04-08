namespace BankAccounts
{
    public class LoanAccount : Account
    {
        private const int minMounthsForCompany = 2;
        private const int minMounthsForIndividuals = 3;

        public LoanAccount(Customers customer, decimal ballance, double interestRate)
            : base(customer, ballance, interestRate)
        {

        }

        public override double InterestAmount(int months)
        {
            if ((this.Customer == Customers.Companies && months <= minMounthsForCompany) ||
               (this.Customer == Customers.Individuals && months <= minMounthsForIndividuals))
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
