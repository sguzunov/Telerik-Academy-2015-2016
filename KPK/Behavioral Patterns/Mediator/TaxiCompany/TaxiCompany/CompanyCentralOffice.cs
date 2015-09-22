namespace TaxiCompany
{
    using System;
    using System.Collections.Generic;

    public class CompanyCentralOffice : Office
    {
        private Dictionary<string, TaxiDriver> drivers = new Dictionary<string, TaxiDriver>();

        public void AddDriver(TaxiDriver newDriver)
        {
            drivers.Add(newDriver.Name, newDriver);
        }

        public override void SendMessage(string senderName, string receiverName, string message)
        {
            var receiver = drivers[receiverName];

            if (receiverName != null)
            {
                receiver.ReceiveMessage(senderName, message);
            }
            else
            {
                Console.WriteLine("There is no driver with name {0}.", receiverName);
            }
        }
    }
}
