namespace SchoolSystemTest
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SchoolSystem;

    [TestClass]
    public class TestCourse
    {
        private const string VALID_COURSE_NAME = "CSharp";

        [TestMethod]
        public void TestCourseCreationWithValidName()
        {
            try
            {
                var course = new Course(VALID_COURSE_NAME);
            }
            catch (Exception)
            {

                Assert.Fail("Expected no exception");
            }
        }

        [TestMethod]
        public void TestCourseIfReturnsRightName()
        {
            var course = new Course(VALID_COURSE_NAME);

            Assert.AreEqual(VALID_COURSE_NAME, course.Name);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestCourseCreationWithNameNull()
        {
            var course = new Course(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestCourseCreationWithNameEmptyString()
        {
            var course = new Course(string.Empty);
        }

        [TestMethod]
        public void TestAddingStudent()
        {
            var course = new Course(VALID_COURSE_NAME);

            course.AddStudent(new Student("John", 55555));
            var students = course.Students;
            int count = students.Count;

            Assert.AreEqual(1, count, "Course contains different count of students than expected.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestAddingNullStudent()
        {
            var course = new Course(VALID_COURSE_NAME);

            course.AddStudent(null);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestOverflowStudentsList()
        {
            var course = new Course(VALID_COURSE_NAME);

            for (int i = 0; i < 30; i++)
            {
                course.AddStudent(new Student(
                    string.Format("Student {0}", i + 1),
                    (10000 + i)));
            }

            course.AddStudent(new Student("John", 55555));
        }

        [TestMethod]
        public void TestRemovingStudent()
        {
            var course = new Course(VALID_COURSE_NAME);
            var student = new Student("John", 55551);

            course.AddStudent(student);
            course.RemoveStudent(student);

            var students = course.Students;
            int count = students.Count;

            Assert.AreEqual(0, count, "Student is not removed from list.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestRemovingNullStudent()
        {
            var course = new Course(VALID_COURSE_NAME);

            course.AddStudent(new Student("John", 55555));
            course.RemoveStudent(null);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestRemovingStudentFromEmptyList()
        {
            var course = new Course(VALID_COURSE_NAME);

            course.RemoveStudent(new Student("John", 55555));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestRemovingNonExistingStudent()
        {
            var course = new Course(VALID_COURSE_NAME);

            course.AddStudent(new Student("John", 55551));
            course.AddStudent(new Student("John", 55552));

            course.RemoveStudent(new Student("John", 55555));
        }
    }
}
