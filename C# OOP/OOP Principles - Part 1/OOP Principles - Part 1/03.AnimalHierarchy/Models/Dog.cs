namespace AnimalHierarchy.Models
{
    using System;

    public class Dog : Animal
    {
        private string breed;

        public Dog(string aName, byte aAge, string aSex, string aBreed)
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
            Console.WriteLine("Bau");
        }

        public string Faithfulness()
        {
            if (base.Age > 2)
            {
               return  string.Format("{0} is a faithful dog.", base.Name);
            }
            else 
            {
                return string.Format("{0} is not a faithful dog.", base.Name);
            }
        }
    }
}
