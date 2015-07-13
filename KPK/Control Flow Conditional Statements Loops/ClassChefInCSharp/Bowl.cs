namespace ClassChefInCSharp
{
    using System.Collections.Generic;

    public class Bowl
    {
        private List<Vegetable> vegetables = new List<Vegetable>();

        public Bowl()
        {
            // TODO
        }

        public void Add(Vegetable newVegetable)
        {
            this.vegetables.Add(newVegetable);
        }
    }
}
