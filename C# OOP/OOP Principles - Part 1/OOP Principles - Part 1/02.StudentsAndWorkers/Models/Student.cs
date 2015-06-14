namespace StudentsAndWorkers.Models
{
    using System;

    public class Student : Human
    {        
        private byte grade;

        public Student(string fName, string lName, byte grd)
            : base(fName, lName)
        {
            this.Grade = grd;
        }

        public byte Grade
        {
            get 
            {
                return this.grade;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Incorrect input data!");
                }

                this.grade = value;
            }
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }
 
    }    
}
