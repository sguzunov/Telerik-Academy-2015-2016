using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBrowser
{
    public class Program
    {
        static void Main(string[] args)
        {
            var browser = Browser.GetInstance;
            browser.LoadPage("example.com");
            browser.LoadPage("abv.com");
            browser.LoadPage("gmail.com");
            browser.LoadPage("example.com");

            browser.LoadPreviousPage();
            browser.LoadNextPage();
            browser.LoadNextPage();
        }
    }
}
