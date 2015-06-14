namespace FarmersCreed.Units
{
    using System;
    using FarmersCreed.Interfaces;

    public class Cow : Animal
    {
        private const int BaseHealth = 15;
        private const ProductType CowProductType = ProductType.Milk;
        private const FoodType CowFoodType = FoodType.Organic;
        private const int BaseHealthEffect = 4;
        private const int Quantity = 6;

        public Cow(string id)
            : base(id, BaseHealth, Quantity)
        { 
        }

        public override void Eat(IEdible food, int quantity)
        {
            switch (food.FoodType)
            {
                case FoodType.Organic:
                    {
                        this.Health += BaseHealthEffect * quantity;
                        break;
                    }
                case FoodType.Meat:
                    {
                        this.Health -= BaseHealthEffect * quantity;
                        break;
                    }
                default:
                    break;
            }
        }

        public override Product GetProduct()
        {
            if (!this.IsAlive)
            {
                throw new InvalidOperationException("You cannot produce milk if cow is dead.");
            }

            this.Health -= 2;

            return new Food(this.Id + ProductSuffix, CowProductType, CowFoodType, Quantity, BaseHealthEffect);
        }
    }
}
