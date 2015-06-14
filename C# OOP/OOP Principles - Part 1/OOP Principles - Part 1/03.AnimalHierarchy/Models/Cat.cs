namespace AnimalHierarchy.Models
{
    using System;

    public class Cat : Animal
    {
        private string breed;

        public Cat(string aName, byte aAge, string aSex, string aBreed)
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
            Console.WriteLine("Maaauuuuu");
        }

        public virtual string Cuteness()
        {
            return string.Format("{0} is a loving cat.", base.Name);
        }
    }
}
