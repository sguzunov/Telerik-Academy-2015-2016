namespace FarmersCreed.Units
{
    using System;

    public class TobaccoPlant : Plant
    {
        private const int BaseHealth = 12;
        private const int GrownTime = 4;
        private const ProductType Type = ProductType.Tobacco;
        private const int Quantity = 10;

        public TobaccoPlant(string id)
            : base(id, BaseHealth, Quantity, GrownTime)
        {           
        }

        public override void Grow()
        {
            for (int i = 0; i < 2; i++)
            {
                base.Grow();  
            }            
        }

        public override Product GetProduct()
        {
            if (this.IsAlive == false)
            {
                throw new InvalidOperationException("You cannot exploit dead tobacco plant.");
            }
            else if (this.HasGrown == false)
            {
                throw new InvalidOperationException("You cannot exploit growing tobacco plant.");
            }

            return new Product(this.Id+ ProductSuffix, Type, Quantity);
        }

    }
}
