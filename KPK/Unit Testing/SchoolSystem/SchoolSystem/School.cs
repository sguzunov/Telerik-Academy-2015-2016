namespace SchoolSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class School
    {
        private string name;
        private IList<Course> courses;
        private IList<Student> students;

        public School(string name)
        {
            this.Name = name;
            this.courses = new List<Course>();
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

        public IList<Course> Courses
        {
            get
            {
                return this.courses;
            }
        }

        public void AddCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException("Added course cannot be null");
            }

            this.AddStudentsToSchoolList(course);
            this.courses.Add(course);
        }

        public void RemoveCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException("Removed course cannot be null.");
            }

            if (!this.courses.Any(c => c.Equals(course)))
            {
                throw new ArgumentException("Such a course does not exists in the list of school courses.");
            }

            this.courses.Remove(course);
        }

        private void AddStudentsToSchoolList(Course course)
        {
            var courseStudents = course.Students;
            for (int i = 0; i < courseStudents.Count; i++)
            {
                var currentStudent = courseStudents[i];

                if (this.students.Any(st => st.ID == currentStudent.ID))
                {
                    throw new ArgumentException("The course must not have a student with ID already used.");
                }

                this.students.Add(currentStudent);
            }
        }
    }
}
