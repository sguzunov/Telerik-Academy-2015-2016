namespace MenuConstructor.RestaurantCrews
{

    public abstract class Crew
    {
        protected Menu Menu { get; set; }

        public abstract void AddBurger();

        public abstract void AddDrink();

        public abstract void AddSalad();

        public abstract void AddDessert();
    }
}
