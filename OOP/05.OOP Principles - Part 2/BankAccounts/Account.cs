namespace BankAccounts
{
    public abstract class Account : IDeposit
    {
        public Account(Customers customer, decimal ballance, double interestRate)
        {
            this.Customer = customer;
            this.Ballance = ballance;
            this.InterestRate = interestRate;
        }

        public Customers Customer { get; private set; }
        public decimal Ballance { get; set; }
        public double InterestRate { get; private set; }

        public abstract double InterestAmount(int months);

        public void DepositMoney(decimal deposit)
        {
            this.Ballance += deposit;
        }
    }
}
