namespace MenuConstructor.RestaurantCrews
{
    public class KidsMenuCrew : Crew
    {

        public KidsMenuCrew()
        {
            this.Menu = new Menu("Kids");
        }

        protected override void AddBurger()
        {
            this.Menu["burger"] = "Big Shmak";
        }

        protected override void AddDrink()
        {
            this.Menu["drink"] = "Cola";
        }

        protected override void AddSalad()
        {
            this.Menu["salas"] = "Shopska";
        }

        protected override void AddDessert()
        {
            this.Menu["dessert"] = "Cookie";
        }
    }
}
