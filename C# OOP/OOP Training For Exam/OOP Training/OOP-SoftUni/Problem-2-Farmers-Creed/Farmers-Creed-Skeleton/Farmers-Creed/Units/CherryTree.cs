namespace FarmersCreed.Units
{
    using System;

    public class CherryTree : FoodPlant
    {
        private const int BaseHealth = 24;
        private const int GrowTime = 3;
        private const ProductType CherryProductType = ProductType.Cherry;
        private const FoodType CherryFoodType = FoodType.Organic;
        private const int ProductionQuantity = 4;
        private const int BaseHealthEffect = 2;

        public CherryTree(string id)
            : base(id, BaseHealth, ProductionQuantity, GrowTime)
        { 
        }

        public override Product GetProduct()
        {
            if (!this.IsAlive)
            {
                throw new InvalidOperationException("You cannot produce dead cherry tree.");
            }

            return new Food(this.Id, CherryProductType, CherryFoodType, ProductionQuantity, BaseHealthEffect);
        }

    }
}
