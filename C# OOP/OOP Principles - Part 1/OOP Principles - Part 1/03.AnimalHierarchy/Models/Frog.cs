namespace AnimalHierarchy.Models
{
    using System;

    public class Frog : Animal
    {
        private string breed;

        public Frog(string aName, byte aAge, string aSex, string aBreed)
            : base(aName, aAge, aSex)
        {
            this.Breed = aBreed;
        }

        public override string Breed
        {
            get
            {
                return this.breed;
            }
            set
            {
                this.breed = value;
            }
        }

        public override void Sound()
        {
            Console.WriteLine("Croak");
        }
    }
}
