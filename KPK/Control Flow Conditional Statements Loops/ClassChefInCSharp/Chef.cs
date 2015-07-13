namespace ClassChefInCSharp
{
    using System;

    public class Chef
    {
        public void Cook()
        {
            Bowl bowl = this.GetBowl();
            Carrot carrot = this.GetCarrot();
            Potato potato = this.GetPotato();

            this.Cut(carrot);
            this.Cut(potato);

            this.Peel(carrot);
            this.Peel(potato);

            bowl.Add(carrot);
            bowl.Add(potato);
        }

        private void Cut(Vegetable potato)
        {
            // TODO
        }

        private void Peel(Vegetable vegetable)
        {
            // TODO
        }

        private Bowl GetBowl()
        {
            return new Bowl();
        }

        private Carrot GetCarrot()
        {
            return new Carrot();
        }

        private Potato GetPotato()
        {
            return new Potato();
        }
    }
}
