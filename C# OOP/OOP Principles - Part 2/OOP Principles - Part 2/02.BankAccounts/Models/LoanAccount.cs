namespace BankAccounts.Models
{
    using System;
    using BankAccounts.Interfaces;

    public class LoanAccount : Accounts,IDepositable
    {
        private const int NoInterestIndividuals = 3;
        private const int NoInterestCompanies = 2;

        public LoanAccount(Customers custom, decimal bal, decimal intRate)
            : base(custom, bal, intRate)
        { 
        }

        public override decimal CalculateInterestAmount(int period)
        {
            if (period < 0)
            {
                throw new ArgumentException("The period CANNOT be negative number.");
            }
            if (base.Customer is IndividualCustomer)
            {
                if (period <= NoInterestIndividuals)
                {
                    return 0.0m;
                }
            }
            else if (base.Customer is CompanyCustomer)
            {
                if (period <= NoInterestCompanies)
                {
                    return 0.0m;
                }
            }

            return this.InterestRate * period;
        }

        public void Depositing(decimal amount)
        {
            base.Balance += amount;
        }
    }
}
