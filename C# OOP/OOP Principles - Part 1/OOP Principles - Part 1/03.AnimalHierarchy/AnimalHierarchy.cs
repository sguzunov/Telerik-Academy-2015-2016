namespace AnimalHierarchy
{
    using System;
    using AnimalHierarchy.Models;

    public class AnimalHierarchyMain
    {
        static void Main()
        {
            Dog[] dogs = 
            {
                new Dog("Sharo",4,"Male","dakel"),
                new Dog("Chocho",2,"Male","pincher"),
                new Dog("Sara",10,"Female","pudel")
            };

            Cat[] cats = 
            {
                new Cat("Rijko",4,"Male","Egyptian Mau"),
                new Cat("Belka",2,"Female","Devon Rex"),
                new Cat("Koko",10,"Male","Havana Brown")
            };

            Frog[] frogs =
            {
                new Frog("Green",3,"Male","Bufo"),
                new Frog("Harry",1,"Male","Hyla")
            };

            Kitten[] kittens =
           {
               new Kitten("Snow White",4,"Burmese"),
               new Kitten("Vins",2,"Korat")
           };

            Tomcat[] tomcats =
            {
               new Tomcat("Gilbert",4,"Manx"),
               new Tomcat("Dee Dee",2,"Munchkin"),
               new Tomcat("Vins",2,"Nebelung"),
               new Tomcat("Tig",2,"Persian"),
            };

            Console.WriteLine("Dogs average age: {0:F2}", Animal.AverageAge(dogs));
            Console.WriteLine("Cats average age: {0:F2}", Animal.AverageAge(cats));
            Console.WriteLine("Frogs average age: {0:F2}", Animal.AverageAge(frogs));
            Console.WriteLine("Kittens average age: {0:F2}", Animal.AverageAge(kittens));
            Console.WriteLine("Tomcats average age: {0:F2}", Animal.AverageAge(tomcats));
        }       
    }

    /*
     Ceate a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. Dogs, frogs and cats are Animals. All animals can produce sound (specified by the ISound interface). Kittens and tomcats are cats. All animals are described by age, name and sex. Kittens can be only female and tomcats can be only male. Each animal produces a specific sound.
Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method (you may use LINQ).
     */
}
