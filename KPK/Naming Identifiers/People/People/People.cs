namespace People
{
    using System;

    public class People
    {
        static void Main()
        {
            var malePerson = new Person();
            var femalePerson = new Person();

            malePerson = malePerson.CreatePerson(20);
            femalePerson = femalePerson.CreatePerson(19);

            Console.WriteLine(malePerson);
            Console.WriteLine(femalePerson);
        }
    }
}
