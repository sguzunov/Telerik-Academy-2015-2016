namespace TaxiCompany
{
    using System;

    public class Program
    {
        static void Main()
        {
            var companyOffice = new CompanyCentralOffice();
            var yellowDriver = new YellowTaxiDriver("Pesho", companyOffice);
            var yellowDriver1 = new YellowTaxiDriver("Pesho1", companyOffice);
            var yellowDriver2 = new YellowTaxiDriver("Pesho2", companyOffice);
            var greenDriver = new GreenTaxiDriver("Gosho", companyOffice);
            var greenDriver1 = new GreenTaxiDriver("Gosho1", companyOffice);

            companyOffice.AddDriver(yellowDriver);
            companyOffice.AddDriver(yellowDriver1);
            companyOffice.AddDriver(yellowDriver2);
            companyOffice.AddDriver(greenDriver);
            companyOffice.AddDriver(greenDriver1);

            yellowDriver.SendMessage(greenDriver1.Name, "Don't drive if you have drunk alchohol");
        }
    }
}
