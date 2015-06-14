namespace GroupedByGroupNumber
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Text;

    public class GroupedByGroupNumberMain
    {
        static void Main()
        {
            List<Students> students = new List<Students>()
            {
                new Students("Gospodin","Math"),
                new Students("Stoqn","Biology"),
                new Students("Rumen","Computer science"),
                new Students("Ivelina","Software engineering"),
                new Students("Mima","Math"),
                new Students("Georgi","Iconomics"),
                new Students("Pesho","Information technologies")
            };

            var result = students.OrderBy(st => st.GroupName);  // problem 18

           // var result = students.OrderByGroupName();  // problem 19

            foreach (var student in result)  // problem 18,19
            {
                Console.WriteLine(student);
            }
            



        }
    }

    // 18.Create a program that extracts all students grouped by GroupNumber and then prints them to the console.Use LINQ


}
