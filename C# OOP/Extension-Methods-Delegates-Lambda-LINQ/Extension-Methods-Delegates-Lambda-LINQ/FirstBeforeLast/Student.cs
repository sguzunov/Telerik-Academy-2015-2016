namespace FirstBeforeLast
{
    using System;
    
    public class Student
    {
        public Student(string fName, string lName,int age)
        {
            this.FirstName = fName;
            this.LastName = lName;
            this.Age = age;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }
    }
}
