namespace WebBrowser
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Threading;

    public class Requester
    {
        public string MakeRequest(string url)
        {
            Thread.Sleep(1000);

            return "Request sent";
        }
    }
}
