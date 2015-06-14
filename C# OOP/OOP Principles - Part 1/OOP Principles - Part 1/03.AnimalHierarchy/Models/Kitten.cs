namespace AnimalHierarchy.Models
{
    using System;

    public class Kitten : Cat
    {      
       public Kitten(string aName, byte aAge, string aBreed)
            : base(aName, aAge, "Female", aBreed)
        {
            
        }       
    }
}
