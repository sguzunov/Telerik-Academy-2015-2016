namespace TaxiCompany
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public abstract class Office
    {
        public abstract void SendMessage(string senderName, string receiverName, string message);
    }
}
