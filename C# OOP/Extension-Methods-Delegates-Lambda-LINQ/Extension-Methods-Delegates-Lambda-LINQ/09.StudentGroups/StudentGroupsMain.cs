namespace StudentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StudentGroupsMain
    {
            public static List<Student> allStudents = new List<Student>
            {
                new Student("Ivan","Petrov","141506693","359288963148",new List<double>{6,4,5},"vankata@abv.bg",2),
                new Student("Stoqn","Georgiev","141578025","359882459873",new List<double>{6,6,6,6,5},"stoqng.88@gmail.bg",1),
                new Student("Dinko","Ivanov","141578123","359288998764",new List<double>{5,5,6},"dichkata1234@abv.bg",2),
                new Student("Yavor","Malendakov","141578456","359872341895",new List<double>{4,6,3,2,2},"yavkatagld1515@abv.bg",3),
                new Student("Yasen","Mechkov","072579634","359889217456",new List<double>{2,4,5},"rallyteam@yahoo.bg",1),
                new Student("Rumen","Mavrodiev","012506630","359987654321",new List<double>{4,5,6},"rumbatamanunt@abv.bg",3),
                new Student("Kalina","Petrova","179625784","359288963145",new List<double>{4,2,4,6,2},"kikamika@gmail.bg",4)         
            };


        static void Main()
        {

            var studentsInGroupTwo = allStudents.Where(st => st.AttendedGroup == 2); // problem 9

            var orderedByFirstName = allStudents.OrderBy(st => st.FirstName); // problem 9

            var studentsWithAbvEmail = allStudents.Where(st => st.Email.Contains("abv.bg")); // problem 11

            var studentInSofia = allStudents.Where(st => st.TelephoneNumber.Contains("3592"));  // problem 12
                        
            var studentsWithTwo2 = allStudents.StudentsWithBadResults(); // problem 14

            var studentsFrom2006Y = allStudents.Where(st => st.FN.Substring(4, 2) == "06");  // problem 15
            
          //  StudentsFromMathematicsDepartment(allStudents);  // problem 16

           }

        private static void StudentsWithAtLeastOne6(List<Student> allStudents) // problem 13
        {
            var studentsWithAtLeastOne6 = allStudents.Where(st => st.Marks.Contains(6))  
                 .Select(st => new
                 {
                     FullName = st.FirstName + " " + st.LastName,
                     Marks = st.Marks
                 });

            foreach (var item in studentsWithAtLeastOne6)
            {
                Console.WriteLine(item.FullName+"\n"+string.Join(" ",item.Marks));
            }                        
        }

        private static void StudentsFromMathematicsDepartment(List<Student> allStudents) // problem 16
        {
            var groups = new List<Groups> 
            {
                new Groups(1,"Mathematics"),
                new Groups(1,"Georgraphy"),
                new Groups(1,"Law"),
                new Groups(1,"Medicine")                
            };
 
            var mathStudents =
                from st in allStudents
                join gr in groups on st.AttendedGroup equals gr.GroupNumber
                where gr.DepartmentName=="Mathematics"
                select st;

            foreach (var item in mathStudents)
        	{
        		 Console.WriteLine(item);
        	}

        }

    }


    /*
     09.Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
        Create a List<Student> with sample students. Select only the students that are from group number 2.
        Use LINQ query. Order the students by FirstName. 
      
      10.Implement the previous using the same query expressed with extension methods.
      
      11. Extract all students that have email in abv.bg.
          Use string methods and LINQ.
      
      12.Extract all students with phones in Sofia.
            Use LINQ.
      
      13.Select all students that have at least one mark Excellent (6) into a new anonymous class that has properties – FullName and Marks.
            Use LINQ.
      
     14. Write down a similar program that extracts the students with exactly two marks "2".
        Use extension methods 
      
      15.Extract all Marks of the students that enrolled in 2006. (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).
      
      16.Create a class Group with properties GroupNumber and DepartmentName.
        Introduce a property GroupNumber in the Student class.
        Extract all students from "Mathematics" department.
        Use the Join operator.     
      
     */
}