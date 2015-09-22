namespace TaxiCompany
{
    using System;

    public abstract class TaxiDriver
    {
        protected Office office;

        public TaxiDriver(string name, Office office)
        {
            this.Name = name;
            this.office = office;
        }

        public string Name { get; set; }

        public void SendMessage(string receiverName, string message)
        {
            this.office.SendMessage(this.Name, receiverName, message);
        }

        public void ReceiveMessage(string senderName, string message)
        {
            Console.WriteLine("Message from: {0}.\n{1}", senderName, message);
        }
    }
}
