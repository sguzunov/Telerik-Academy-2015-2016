namespace MenuConstructor.Director
{
    using MenuConstructor.RestaurantCrews;

    public class Cashier
    {
        public Cashier(Crew crew)
        {
            crew.AddSalad();
            crew.AddBurger();
            crew.AddDrink();
            crew.AddDessert();
        }
    }
}
