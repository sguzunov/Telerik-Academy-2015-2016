namespace SchoolSystemTest
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SchoolSystem;

    [TestClass]
    public class TestStudent
    {
        private const string VALID_NAME = "John";
        private const int VALID_ID = 10011;

        [TestMethod]
        public void TestStudentCreationWithValidNameAndValidId()
        {
            try
            {
                var student = new Student(VALID_NAME, VALID_ID);
            }
            catch (Exception)
            {

                Assert.Fail("Expected no exception");
            }
        }

        [TestMethod]
        public void TestStudentIfReturnsRightName()
        {
            var student = new Student(VALID_NAME, VALID_ID);

            Assert.AreEqual(VALID_NAME, student.Name);
        }

        [TestMethod]
        public void TestStudentIfReturnsRightId()
        {
            var student = new Student(VALID_NAME, VALID_ID);

            Assert.AreEqual(VALID_ID, student.ID);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestStudentCreationWithNameNullAndValidId()
        {
            var st = new Student(null, VALID_ID);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestStudentCreationWithNameEmptyStringAndValidId()
        {
            var st = new Student(string.Empty, VALID_ID);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestStudentCreationWithValidNameAndIdLessThan10000()
        {
            var st = new Student(VALID_NAME, 9999);
        }

        [TestMethod]
        public void TestStudentCreationWithValidNameAndIdEqualTo10000()
        {
            try
            {
                var student = new Student(VALID_NAME, 10000);
            }
            catch (Exception)
            {

                Assert.Fail("Expected no exception");
            }
        }

        public void TestStudentCreationWithValidNameAndIdMoreThan99999()
        {
            var st = new Student(VALID_NAME, 100000);
        }

        [TestMethod]
        public void TestStudentCreationWithValidNameAndIdEqualTo99999()
        {
            try
            {
                var student = new Student(VALID_NAME, 99999);
            }
            catch (Exception)
            {

                Assert.Fail("Expected no exception");
            }
        }
    }
}
