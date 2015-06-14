namespace StudentsAndWorkers
{
    using System;
    using StudentsAndWorkers.Models;
    using System.Collections.Generic;
    using System.Linq;

    public class StudentsAndWorkersSystem
    {
       static List<Student> students = new List<Student>()
            {
                new Student("Gosho","Georgiev",4),
                new Student("Petyr","Petrov",5),
                new Student("Stoqn","Stoqnov",6),
                new Student("Dinko","Dinev",6),
                new Student("Ivan","Ivanov",4),
                new Student("Rumen","Rumenov",2),
                new Student("Svetla","Svetlanova",5),
                new Student("Maria","Marinova",3),
                new Student("Genadi","Grozdanov",3),
                new Student("Mira","Dobreva",5)
            };

       static List<Worker> workers = new List<Worker>()
            {
                new Worker("Iordan","Stankov",150,8),
                new Worker("Milen","Dimitrov",187,8),
                new Worker("Asq","Mihaleva",300,9),
                new Worker("Doncho","Dinev",220,12),
                new Worker("Ivan","Ivanov",200,8),
                new Worker("Iliqn","Benov",180,8),
                new Worker("Toncho","Momchilov",230,7),
                new Worker("Atanas","Brashlqnov",140,6),
                new Worker("Grozdan","Genadiev",170,8),
                new Worker("Mira","Ivanova",400,10)
            };

        static void Main()
        {
            //  var result = students.OrderBy(st => st.Grade);

           // var result = workers.OrderByDescending(wr => wr.MoneyPerHour());

            var merged = MergeWorkersAndStudents(students, workers);

            var result = merged.OrderBy(m => m.FirstName).ThenBy(m => m.LastName);

            foreach (var worker in result)
            {
                System.Console.WriteLine(worker);
            }

        }

        static List<Human> MergeWorkersAndStudents(List<Student> oldStudents,List<Worker> oldWorkers)
        {
            var merged = new List<Human>();

            for (int i = 0; i < 10; i++)
            {
                merged.Add(oldStudents[i]);
            }

            for (int i = 0; i < 10; i++)
            {
                merged.Add(oldWorkers[i]);
            }

            return merged;
        }
        
    }


    /*
     Define abstract class Human with a first name and a last name. Define a new class Student which is derived from Human and has a new field – grade. Define class Worker derived from Human with a new property WeekSalary and WorkHoursPerDay and a method MoneyPerHour() that returns money earned per hour by the worker. Define the proper constructors and properties for this hierarchy.
Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
Initialize a list of 10 workers and sort them by money per hour in descending order.
Merge the lists and sort them by first name and last name.
     */
}
