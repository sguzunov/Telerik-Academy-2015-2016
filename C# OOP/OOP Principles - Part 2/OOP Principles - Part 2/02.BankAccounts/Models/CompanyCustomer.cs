namespace BankAccounts.Models
{
    public class CompanyCustomer : Customers
    {
        public CompanyCustomer(string nameCompany, string addresCompany, string numberCompany)
            : base(nameCompany, addresCompany, numberCompany)
        {
        } 

        public CompanyCustomer(string nameCompany, string addresCompany, string numberCompany, Accounts accCompany)
            : base(nameCompany, addresCompany, numberCompany, accCompany)
        { 
        }   
    }
}
