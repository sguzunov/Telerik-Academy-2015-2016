namespace Methods
{
    using System;

    /// <summary>
    /// This class provides a basic information for a student.
    /// </summary>
    public class Student : IStudent
    {
        private string firstName;
        private string lastName;
        private string additionalInformation;

        public Student(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
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
                this.lastName = value;
            }
        }

        public string AdditionalInformation
        {
            get
            {
                return this.additionalInformation;
            }

            set
            {
                this.additionalInformation = value;
            }
        }

        public bool IsOlderThan(IStudent studentToCompare)
        {
            DateTime firstBirthDate = this.GetBirthDate(this.AdditionalInformation);
            DateTime secondBirthDate = this.GetBirthDate(studentToCompare.AdditionalInformation);

            bool isOlder = firstBirthDate < secondBirthDate;

            return isOlder;
        }

        private DateTime GetBirthDate(string infoForStudent)
        {
            DateTime birthDate;

            try
            {
                birthDate = DateTime.Parse(infoForStudent.Substring(infoForStudent.Length - 10));
            }
            catch (Exception)
            {
                throw new ArgumentException("Invalid student information. Date parsing impossible.");
            }

            return birthDate;
        }
    }
}
