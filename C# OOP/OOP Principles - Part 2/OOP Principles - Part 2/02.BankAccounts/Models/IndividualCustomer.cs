namespace BankAccounts.Models
{
    public class IndividualCustomer : Customers
    {
        public IndividualCustomer(string nameIndividual, string addresIndividual, string numberIndividual)
            : base(nameIndividual, addresIndividual, numberIndividual)
        {
        } 

        public IndividualCustomer(string nameIndividual, string addresIndividual, string numberIndividual, Accounts accIndividual)
            : base(nameIndividual, addresIndividual, numberIndividual, accIndividual)
        { 
        } 
    }
}
