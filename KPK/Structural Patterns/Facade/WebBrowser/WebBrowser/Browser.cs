namespace WebBrowser
{
    using System;
    using System.Collections.Generic;

    public sealed class Browser
    {
        private static volatile Browser instance;
        private static object syncRoot = new object();

        private int currentUrlIndex;
        private IList<string> sessionUrls = new List<string>();
        private Requester requester = new Requester();
        private Template template = new Template();

        private Browser()
        {
        }

        public static Browser GetInstance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                        {
                            instance = new Browser();
                        }
                    }
                }

                return instance;
            }
        }

        public void LoadPage(string url)
        {
            this.sessionUrls.Add(url);
            this.currentUrlIndex = this.sessionUrls.Count - 1;

            this.requester.MakeRequest(url);
            this.template.LoadPageTemplate(url);

            Console.WriteLine("Page loaded.");
        }

        public void LoadPreviousPage()
        {
            if (this.currentUrlIndex < 1)
            {
                Console.WriteLine("There is no previous page.");
            }
            else
            {
                this.currentUrlIndex -= 1;
                string url = this.sessionUrls[this.currentUrlIndex];

                this.requester.MakeRequest(url);
                this.template.LoadPageTemplate(url);

                Console.WriteLine("Previous page loaded.");
            }
        }

        public void LoadNextPage()
        {
            if (this.currentUrlIndex > (this.sessionUrls.Count - 2))
            {
                Console.WriteLine("There is no next page.");
            }
            else
            {
                this.currentUrlIndex += 1;
                string url = this.sessionUrls[this.currentUrlIndex];

                this.requester.MakeRequest(url);
                this.template.LoadPageTemplate(url);

                Console.WriteLine("Next page loaded.");
            }
        }
    }
}
