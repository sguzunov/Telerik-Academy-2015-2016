namespace BankAccounts.Models
{
    using System;
    using BankAccounts.Interfaces;

    public class DepositAccount : Accounts,IDepositable,IWithDrawable
    {
        public DepositAccount(Customers custom, decimal bal, decimal intRate)
            : base(custom, bal, intRate)
        { 
        }

        public void Depositing(decimal amount)
        {
            base.Balance += amount;
        }

        public void WithDrawing(decimal amount)
        {
            base.Balance -= amount;
        }

        public override decimal CalculateInterestAmount(int period)
        {
            if (period < 0)
            {
                throw new ArgumentException("Incorrect input data.The period must be > 0.");
            }
            if ((base.Balance > 0) && (base.Balance < 1000))
            {
                return 0.0m;
            }
            else
            {
                return period * base.InterestRate;
            }
        }
    }
}
