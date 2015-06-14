namespace AnimalHierarchy.Models
{
    using AnimalHierarchy.Interfaces;

    public class Tomcat : Cat
    {        
        public Tomcat(string aName, byte aAge, string aBreed)
            : base(aName, aAge,"Male", aBreed)
        {
            
        }               
    }
}
