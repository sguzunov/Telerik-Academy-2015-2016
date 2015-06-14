namespace BankAccounts.Models
{
    using System;
    using BankAccounts.Interfaces;

    public class MortgageAccount : Accounts,IDepositable
    {
        private const int InterestForCompanies = 12;
        private const int InterestForIndividuals = 6;

        public MortgageAccount(Customers custom, decimal bal, decimal intRate)
            : base(custom, bal, intRate)
        { 
        }

        public void Depositing(decimal amount)
        {
            base.Balance += amount;
        }

        public override decimal CalculateInterestAmount(int period)
        {
            if (period < 0)
            {
                throw new ArgumentNullException("The period CANNOT be a negative number");
            }
            if (base.Customer is CompanyCustomer)
            {
                if (period <= InterestForCompanies)
                {
                    return period * base.InterestRate / 2;
                }                
            }
            else if (base.Customer is IndividualCustomer)
            {
                if (period <= InterestForIndividuals)
                {
                    return 0.0m;
                }               
            }

            return period * base.InterestRate;
        }
    }
}
