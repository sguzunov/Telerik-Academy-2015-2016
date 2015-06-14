namespace FarmersCreed.Units
{
    using System;
    using FarmersCreed.Interfaces;

    public abstract class FoodPlant : Plant 
    {
        private const int BaseIncreaseHealth = 1;

        public FoodPlant(string id, int health, int productionQuantity, int growTime)
            : base(id, health, productionQuantity, growTime)
        { 
        }

        public override void Water()
        {
            this.Health += BaseIncreaseHealth;
        }

        public override void Wither()
        {
            for (int i = 0; i < 2; i++)
            {
                base.Wither();
            }
        }
    }
}
