namespace MenuConstructor.RestaurantCrews
{
    public class FatMenuCrew : Crew
    {
        public FatMenuCrew()
        {
            this.Menu = new Menu("Fatty");
        }

        protected override void AddBurger()
        {
            this.Menu["burger"] = "Svinski";
        }

        protected override void AddDrink()
        {
            this.Menu["drink"] = "Sprite";
        }

        protected override void AddSalad()
        {
            this.Menu["salad"] = "Ruska salata";
        }

        protected override void AddDessert()
        {
            this.Menu["dessert"] = "sladoled";
        }
    }
}
