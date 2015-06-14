namespace SchoolClasses.Models
{
    using System;
    using SchoolClasses.Interfaces;

    public class Students : Person,IStudent
    {
        private ushort uniqueNumber;

        public Students(string firstName, string lastName,ushort number)
            : base(firstName, lastName)
        {
            this.UniqueNumber = number;
        }

        public ushort UniqueNumber
        {
            get 
            {
                return this.uniqueNumber;
            }
            set
            {
                this.uniqueNumber = value;
            }
        }        
    }
}
