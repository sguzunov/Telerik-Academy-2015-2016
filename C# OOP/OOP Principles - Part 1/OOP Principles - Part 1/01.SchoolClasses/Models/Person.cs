namespace SchoolClasses.Models
{
    using System;
    using SchoolClasses.Interfaces;
using System.Collections.Generic;

    public class Person : IComment
    {
        private string firstName;
        private string lastName;
       
        public Person()
        {
 
        }

        public Person(string fName, string lName)
        {
            this.FirstName = fName;
            this.LastName = lName;
        }

        protected string FirstName
        {
            get 
            {
                return this.firstName;
            }
            set
            {
                if (IsValidName(value) == false)
                {
                    throw new ArgumentException("Incorrect input data for name field!");
                }

                 this.firstName=value;
            }
        }

        protected string LastName
        {
            get 
            {
                return this.lastName;
            }
            set
            {
                if (IsValidName(value) == false)
                {
                    throw new ArgumentException("Incorrect input data for name field!");
                }

                 this.lastName=value;
            }
        }

        public List<string> Comment { get; set; }

        public void AddComment(string comm)
        {
            this.Comment.Add(comm);
        }
        
        private bool IsValidName(string name)
        {
            if (name[0] < 'A' || name[0] > 'Z')
            {
                return false;
            }

            foreach (var ch in name)
            {
                if (char.IsDigit(ch))
                {
                    return false;
                }
            }

            if (name == null)
            {
                return false;
            }

            return true;
        }

        public override string ToString()
        {
            return string.Format(this.FirstName + " " + this.LastName);
        }

    }
}
