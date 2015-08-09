namespace SchoolSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Course
    {
        private const int MAX_STUDENTS_COUNT = 30;

        private string name;
        private IList<Student> students;

        public Course(string name)
        {
            this.Name = name;
            this.students = new List<Student>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                Validator.ValidateName(value);

                this.name = value;
            }
        }

        public IList<Student> Students
        {
            get
            {
                return this.students;
            }
        }

        public void AddStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("Added student cannot be null.");
            }

            if (this.students.Count + 1 > MAX_STUDENTS_COUNT)
            {
                throw new InvalidOperationException("Students list is full");
            }

            this.students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("Removed student cannot be null.");
            }

            if (this.students.Count == 0)
            {
                throw new InvalidOperationException("There are no students left in list");
            }

            if (!this.students.Any(s => s.Equals(student)))
            {
                throw new ArgumentException("Such a student does not exists in the list of course students.");
            }

            this.students.Remove(student);
        }
    }
}
