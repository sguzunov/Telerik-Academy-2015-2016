namespace WebBrowser
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Template
    {
        public string LoadPageTemplate(string templateName)
        {
            string template = string.Empty;

            if (CheckIfFileExists(templateName))
            {
                template = this.GetFileContent(templateName);
            }

            return template;
        }

        private string GetFileContent(string fileName)
        {
            // Opening file and reading content

            return "Some HTML";
        }

        private bool CheckIfFileExists(string filename)
        {
            // Some checking

            return true;
        }
    }
}
