namespace PersonClass
{
    using System;

    public class PersonClassMain
    {
        static void Main()
        {
            Person person1 = new Person("John");     // Age is null by default in constructor
            Console.WriteLine(person1);              // Age is null by default in constructor

            Person person2 = new Person("Carter", 28);      // Age is set with a value different form null
            Console.WriteLine(person2);                     // Age is set with a value different form null

            Person person3 = new Person("Lii", null);    // We set null 
            Console.WriteLine(person3);                    // We set null 
        }
    }

    // Create a class Person with two fields – name and age. Age can be left unspecified (may contain null value. Override ToString() to display the information 
  //  of a person and if age is not specified – to say so.Write a program to test this functionality.
}
