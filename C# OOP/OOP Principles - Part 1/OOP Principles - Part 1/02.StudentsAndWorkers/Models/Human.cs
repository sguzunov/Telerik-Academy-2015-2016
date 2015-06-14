namespace StudentsAndWorkers.Models
{
    using System;

    public abstract class Human
    {       
        private string firstName;
        private string lastName;

        public Human(string fName, string lName)
        {
            this.FirstName = fName;
            this.LastName = lName;
        }

        public string FirstName 
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (IsValidName(value) == false)
                {
                    throw new ArgumentException("Incorrect input data!");
                }

                this.firstName = value;
            }                
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (IsValidName(value) == false)
                {
                    throw new ArgumentException("Incorrect input data!");
                }

                this.lastName = value;
            }
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;            
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

    }
}
