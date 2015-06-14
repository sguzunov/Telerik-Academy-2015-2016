namespace StudentGroups
{
    using System.Collections.Generic;
    using System.Linq;

    public static class StudentGroupsExtentions  
    {
        public static IEnumerable<Student> StudentsFromGivenGroup(this IEnumerable<Student> students, int group)  // problem 10
        {
            var selectedStudents = students.Where(st => st.AttendedGroup == 2);

            return selectedStudents;
        }

        public static IEnumerable<Student> OrderedByFirstName(this IEnumerable<Student> students)  // problem 10
        {
            var oredered = students.OrderBy(st => st.FirstName);

            return oredered;
        }

        public static IEnumerable<Student> StudentsWithBadResults(this IEnumerable<Student> students) // problem 14 
        {
            var studentsWithTwo2 = students.Where(st => st.Marks.Count(x => x == 2) == 2);

            return studentsWithTwo2;
        }
    }
}
