namespace BankAccounts.Models
{
    using System;

    public class Accounts 
    {
        private Customers customer;
        private decimal balance;
        private decimal interestRate;

        public Accounts(Customers custom, decimal bal, decimal intRate)
        {
            this.Customer = custom;
            this.Balance = bal;
            this.InterestRate = intRate;
        }

        public Customers Customer
        {
            get 
            {
                return this.customer;
            }
            set
            {                
                this.customer = value;  
            }
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }
            set
            {
                if (value < 0)
                {
                    this.balance = value;
                }
            }
        }

        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }
            set
            {
                if (value < 0)
                {
                    this.interestRate = value;
                }
            }
        }

        public virtual decimal CalculateInterestAmount(int period)
        {
            if (period < 0)
            {
                throw new ArgumentException("The number of months CANNOT be negative.");
            }

            return period * this.InterestRate;          
        }

    }
}
