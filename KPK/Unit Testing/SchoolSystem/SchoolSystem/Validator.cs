namespace SchoolSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class Validator
    {
        public static void ValidateName(string name)
        {
            if (name == string.Empty)
            {
                throw new ArgumentException("Student's name cannot be empty string.");
            }

            if (name == null)
            {
                throw new ArgumentNullException("Student's name cannot be null.");
            }
        }        
    }
}
