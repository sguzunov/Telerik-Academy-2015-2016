namespace SchoolSystemTest
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SchoolSystem;

    [TestClass]
    public class TestSchool
    {
        private const string VALID_SCHOOL_NAME = "Telerik Academy";

        [TestMethod]
        public void TestSchoolCreationWithValidName()
        {
            try
            {
                var school = new School(VALID_SCHOOL_NAME);
            }
            catch (Exception)
            {

                Assert.Fail("Expected no exception");
            }
        }

        [TestMethod]
        public void TestSchoolIfReturnsRightName()
        {
            var school = new School(VALID_SCHOOL_NAME);

            Assert.AreEqual(VALID_SCHOOL_NAME, school.Name);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestSchoolCreationWithNameNull()
        {
            var school = new School(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSchoolCreationWithNameEmptyString()
        {
            var school = new School(string.Empty);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestAddingNullCourse()
        {
            var school = new School(VALID_SCHOOL_NAME);

            school.AddCourse(null);
        }

        [TestMethod]
        public void TestAddingCourses()
        {
            var school = new School(VALID_SCHOOL_NAME);
            var course = new Course("Java");

            school.AddCourse(course);

            Assert.AreSame(course, school.Courses[0], "Course is not added to list.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestRemovingNullCourse()
        {
            var school = new School(VALID_SCHOOL_NAME);

            school.RemoveCourse(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestRemovingNonExistingCourse()
        {
            var school = new School(VALID_SCHOOL_NAME);
            var existingCourse = new Course("Java");
            var nonExistingCourse = new Course("C++");

            school.AddCourse(existingCourse);
            school.RemoveCourse(nonExistingCourse);
        }

        [TestMethod]
        public void TestRemovingExistingCourse()
        {
            var school = new School(VALID_SCHOOL_NAME);
            var existingCourse = new Course("Java");

            school.AddCourse(existingCourse);
            school.RemoveCourse(existingCourse);
            var courses = school.Courses;
            int count = courses.Count;

            Assert.AreEqual(0, count, "Course is not removed from list");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestaAddingStudentsWithSameId()
        {
            var school = new School(VALID_SCHOOL_NAME);
            var course = new Course("Java");

            course.AddStudent(new Student("John", 11111));
            course.AddStudent(new Student("John", 11112));
            course.AddStudent(new Student("John", 11111));
            course.AddStudent(new Student("John", 11115));
            school.AddCourse(course);
        }
    }
}