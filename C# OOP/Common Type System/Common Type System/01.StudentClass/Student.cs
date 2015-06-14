namespace StudentClass
{
    using System;

    public class Student : ICloneable, IComparable<Student>
    {        
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string SSN { get; set; }

        public  string Address { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public int Course { get; set; }

        public SpecialtyEnumeration Specialty { get; set; }

        public UniversitiesEnumeration University { get; set; }

        public FacultiesEnumeration Faculty { get; set; }

        public Student(string fName, string mName, string lName, string ssn, string address,
            string number, string email, int course, SpecialtyEnumeration spec, UniversitiesEnumeration uni, FacultiesEnumeration fac)
        {
            this.FirstName = fName;
            this.MiddleName = mName;
            this.LastName = lName;
            this.SSN = ssn;
            this.Address = address;
            this.PhoneNumber = number;
            this.Email = email;
            this.Course = course;
            this.Specialty = spec;
            this.University = uni;
            this.Faculty = fac;
        }

        public Student(string fName, string mName, string lName, int course, SpecialtyEnumeration spec, UniversitiesEnumeration uni, FacultiesEnumeration fac)
            : this(fName, mName, lName, null, null, null, null, course, spec, uni, fac)
        {
            
        }

        public Student(string fName, string mName, string lName, int course,UniversitiesEnumeration uni)
            : this(fName, mName, lName, null, null, null, null, course, SpecialtyEnumeration.KSI, uni, FacultiesEnumeration.FKSU)
        {

        }

        public override string ToString()
        {
            return string.Format(this.FirstName + " " + this.LastName + "\n" + "Course: " + this.Course);
        }

        public override bool Equals(object obj)
        {
            Student otherStudent=obj as Student;

            if ((this.Course == otherStudent.Course) && (this.University == otherStudent.University))
            {
                return true;
            }

            return false;
        }

        public static bool operator ==(Student firstStudent, Student secondStudent)
        {
           return firstStudent.Equals(secondStudent);
        }

        public static bool operator !=(Student firstStudent, Student secondStudent)
        {
            return !firstStudent.Equals(secondStudent);
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode();
        }

        public object Clone()
        {
            var newStudent = new Student(this.FirstName, this.MiddleName, this.LastName, this.Course, this.University);

            newStudent.SSN = this.SSN;
            newStudent.Address = this.Address;
            newStudent.PhoneNumber = this.PhoneNumber;
            newStudent.Email = this.Email;
            newStudent.Course = this.Course;
            newStudent.Specialty = this.Specialty;
            newStudent.Faculty = this.Faculty;
            newStudent.University = this.University;

            return newStudent;
        }

        public int CompareTo(Student other)
        {
            var namesOfCurrentStudent = this.FirstName + this.MiddleName + this.LastName;
            var namesOfOtherStudent = other.FirstName + other.MiddleName + other.LastName;

            if (namesOfCurrentStudent.CompareTo(namesOfOtherStudent) == 0)
            {
                return this.SSN.CompareTo(other.SSN);
            }

            return namesOfCurrentStudent.CompareTo(namesOfOtherStudent);
        }
    }
}
