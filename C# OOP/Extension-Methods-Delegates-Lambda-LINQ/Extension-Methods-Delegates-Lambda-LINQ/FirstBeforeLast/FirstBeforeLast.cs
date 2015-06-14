namespace FirstBeforeLast
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;

    class FirstBeforeLastMain
    {
        static void Main()
        {
            Student[] arrStudents=
            {
                new Student("Stoqn","Uzunov",15),
                new Student("Georgi","Stankov",19),
                new Student("Aleks","Ivanova",23),
                new Student("Ivan","Atanasov",32),
                new Student("Keti","Pavlova",30),
                new Student("Stiliyan","Dechkov",22),
            };

            var orderedStudents = FirstBeforeLast(arrStudents);  // problem 3

          //  var orderedStudents = AgeRange(arrStudents);  // problem 4

         //   var orderedStudents = OrderedStudents(arrStudents);  // problem 5

            foreach (var student in orderedStudents)
            {
                Console.WriteLine(student);
            }


        } 

        static Student[] FirstBeforeLast(Student[] arr)  // problem 3
        {
            var someByName = arr.Where((student) => student.FirstName.CompareTo(student.LastName) < 0);  // test problem 3
                     
            return someByName.ToArray();
        }

        static Student[] AgeRange(Student[] arr)
        {
            var someByAge = arr.Where((student) => ((student.Age >= 18) && (student.Age <= 24))); // test problem 4
            
            return someByAge.ToArray();
        }

        static Student[] OrderedStudents(Student[] arr)
        {
            var orderedStudents = arr.OrderByDescending(student => student.FirstName).ThenBy(student => student.LastName);   // test problem 5

            return orderedStudents.ToArray();
        }

    }



    /*
     03.Write a method that from a given array of students finds all students whose first name is before its last name alphabetically. Use LINQ query operators.
     04.Write a LINQ query that finds the first name and last name of all students with age between 18 and 24. 
     05.Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order.
        Rewrite the same with LINQ.
      
    */

}
