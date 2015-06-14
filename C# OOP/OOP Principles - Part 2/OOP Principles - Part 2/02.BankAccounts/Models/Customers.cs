namespace BankAccounts.Models
{
    using System;
    using System.Collections.Generic;

    public class Customers
    {
        private string name;
        private string address;
        private string phoneNumber;
        private List<Accounts> accounts;

        public Customers(string nameCustomer, string addr, string number)
        {
            this.Name = nameCustomer;
            this.Address = addr;
            this.PhoneNumber = number;
            this.Accounts = new List<Accounts>();
        }

        public Customers(string nameCustomer,string addr,string number,Accounts acc)
        {
            this.Name = nameCustomer;
            this.Address = addr;
            this.PhoneNumber = number;
            this.Accounts = new List<Accounts>();
            this.Accounts.Add(acc);
        }

        public string Name 
        {
            get
            {
                return this.name;
            }
            set
            {
                if (IsValidName(value) == false)
                {
                    throw new ArgumentException("Incorrect input data for name");
                }

                this.name = value;
            }
        }

        public string Address
        {
            get
            {
                return this.address;
            }
            set
            {
                this.address = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }
            set
            {
                if (IsValidNumber(value) == false)
                {
                    throw new ArgumentException(@"Incorrect input data for phone number.Must begin with '359'.");
                }

                this.phoneNumber = value;
            }
        }

        public List<Accounts> Accounts
        {
            get
            {
                return this.accounts;
            }
            set
            {
                this.accounts = value;
            }
        }

        private bool IsValidName(string name)
        {
            if ((name[0] < 'A' || name[0] > 'Z') || name.Length > 50 || name==null)
            {
                return false;
            }

            return true;
        }

        private bool IsValidNumber(string number)
        {
            string start = name.Substring(0, 3);
            if (start != "359")
            {
                return false;
            }

            return true;
        }
    }
}
