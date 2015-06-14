namespace FarmersCreed.Units
{
    using System;
    using FarmersCreed.Interfaces;

    public class Swine : Animal
    {
        private const int BaseHealth = 20;
        private const ProductType SwineProductType = ProductType.PorkMeat;
        private const FoodType SwineFoodType = FoodType.Meat;
        private const int HealthEffect = 5;
        private const int ProductionQuantity = 1;

        public Swine(string id)
            : base(id, BaseHealth, ProductionQuantity)
        { 
        }

        public override void Starve()
        {
            for (int i = 0; i < 3; i++)
            {
                base.Starve(); 
            }            
        }

        public override void Eat(IEdible food, int quantity)
        {
            switch (food.FoodType)
            {
                case FoodType.Organic:                    
                case FoodType.Meat:
                    {
                        this.Health *= food.HealthEffect * quantity * 2;
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
                throw new InvalidOperationException("You cannot produce meat from dead animal.");
            }

            base.Die();

            return new Food(this.Id + ProductSuffix, SwineProductType, SwineFoodType, ProductionQuantity, HealthEffect);
        }
    }
}
