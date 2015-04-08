namespace BankAccounts
{
    public class DepositAccount : Account , IDraw
    {
        private const int minAmount = 1000;

        public DepositAccount(Customers customer, decimal ballance, double interestRate)
            : base(customer, ballance, interestRate)
        {

        }

        public override double InterestAmount(int months)
        {
            if(this.Ballance < minAmount)
            {
                return 0;
            }
            else
            {
                return this.InterestRate * months;
            }
        }

        public void DrawMoney(decimal draw)
        {
            this.Ballance -= draw;
        }
    }
}
