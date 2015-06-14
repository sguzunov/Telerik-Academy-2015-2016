using System;

class PrintCompanyInformation
{
    static void Main()
    {
        Console.Write("Company name:");
        string companyName = Console.ReadLine();
        Console.Write("Company address:");
        string companyAddress = Console.ReadLine();
        Console.Write("Phone number:");
        string phoneNumber = Console.ReadLine();
        Console.Write("Fax number:");
        string faxNumber = Console.ReadLine();
        Console.Write("Web site:");
        string webSite = Console.ReadLine();
        Console.Write("Manager first name:");
        string firstName = Console.ReadLine();
        Console.Write("Manager last name:");
        string lastName = Console.ReadLine();
        Console.Write("Manager age:");
        string age = Console.ReadLine();
        Console.Write("Manager phone:");
        string managerPhone = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("{0} \nAddres: {1} \nTel. {2} \nFax: {3} \nWeb site: {4} \nManager: {5} {6} (age:{7},tel. {8})",
            companyName,companyAddress,phoneNumber,faxNumber,webSite,firstName,lastName,age,managerPhone);  
            
            
            
            
            
           








    }
}

