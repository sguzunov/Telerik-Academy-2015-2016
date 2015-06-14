namespace StudentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class Student
    {
        private string firstName;
        private string lastName;
        private string facultyNumber;
        private string telephoneNumber;
        private string email;
        private List<double> marks;
        private ushort groupNumber;

        public Student(string fName, string lName, string fn, string telNumber,List<double> inputMarks ,string mail,ushort grp)
        {
            this.FirstName = fName;
            this.LastName = lName;
            this.FN = fn;
            this.TelephoneNumber = telNumber;
            this.marks = inputMarks;
            this.Email = mail;
            this.AttendedGroup = grp;            
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if ((value.Length <= 0) && (value[0] < 'A' || value[0] > 'Z'))
                {
                    throw new ArgumentException("Invalid input data.");
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
                if ((value.Length <= 0) && (value[0] < 'A' || value[0] > 'Z'))  
                {
                    throw new ArgumentException("Invalid input data.");
                }

                this.lastName = value;
            }
        }

        public string FN
        {
            get
            {
                return this.facultyNumber;
            }
            set
            {
                if (value.Length == 0 && validNumber(value)==false)
                {
                    throw new ArgumentException("Invalid input data.");
                }

                this.facultyNumber = value;
            }
        }

        public string TelephoneNumber
        {
            get
            {
                return this.telephoneNumber;
            }
            set
            {
                if (validNumber(value) == false)
                {
                    throw new ArgumentException("Invalid input data.");
                }

                this.telephoneNumber = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if (validEmail(value) == false)
                {
                    throw new ArgumentException("Invalid input data.");
                }

                this.email = value;
            }
        }

        public List<double> Marks
        {
            get
            {
                return this.marks;
            }
        }

        public ushort AttendedGroup
        {
            get
            {
                return this.groupNumber;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Incorrect input data!");
                }

                this.groupNumber = value;
            } 
        }

        public Group GroupNumber { get; set; }

        public void AddMark(double mark)
        {
            this.marks.Add(mark);            
        }

        private bool validEmail(string mail)
        {
            if (!Regex.IsMatch(mail.Trim(),
                 @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                 @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                 RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250)))
            {
                return false;
            }

            return true;
        }


        private bool validNumber(string value)
        {
            foreach (var ch in value)
            {
                if (char.IsLetter(ch))
                {
                    return false;
                    break;
                }
            }

            return true;
        }

        public override string ToString()
        {
            return string.Format("First name: {0}\nLast name: {1}\nFaculty number: {2}\nPhone number: {3}" +
                                   "\nEmail: {4}\nMarks: {5}\nGroup number: {6}", this.FirstName, this.LastName,
                                   this.FN, this.TelephoneNumber, this.Email, string.Join(" ", this.Marks), this.AttendedGroup);

        }

    }
}
