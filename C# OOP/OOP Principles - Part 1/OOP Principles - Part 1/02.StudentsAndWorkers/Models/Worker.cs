namespace StudentsAndWorkers.Models
{
    using System;

    public class Worker : Human
    {
        private double weekSalary;
        private byte workHoursPerDay;

        public Worker(string fNm, string lNm)
            : base(fNm, lNm)
        {

        }

        public Worker(string fNm, string lNm,double salary,byte hours)
            : base(fNm, lNm)
        {
            this.WeekSalary = salary;
            this.WorkHoursPerDay = hours;
        }

        public double WeekSalary
        {
            get 
            {
                return this.weekSalary;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Incorrect input data!");
                }

                this.weekSalary = value;
            }
        }

        public byte WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Incorrect input data!");
                }

                this.workHoursPerDay = value;
            }
        }

        public double MoneyPerHour()
        {
            double result = 0;

            result = this.WeekSalary / (5 * this.WorkHoursPerDay);

            return result;
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }        
    }
}
