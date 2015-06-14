using FarmersCreed.Interfaces;

namespace FarmersCreed.Units
{
    using System;

    public abstract class FarmUnit : GameObject, IProductProduceable 
    {
        public const string ProductSuffix = "Product";

        private int producedQuantity;

        public FarmUnit(string id, int health, int productionQuantity)
            : base(id)
        {
            throw new NotImplementedException();
        }

        public int Health { get; set; }

        public bool IsAlive
        {
            get { return this.Health > 0; }
        }

        public int ProductionQuantity
        {
            get
            {
                return this.producedQuantity;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Product quantity cannot be negative!");
                }
                this.producedQuantity = value;
            }
        }

        public virtual Product GetProduct()
        {
            throw new NotImplementedException();
        }

        public virtual void Die()
        {
            this.Health = 0;
        }

        public override string ToString()
        {
            return base.ToString() + (this.IsAlive ? string.Format(", Health: {0}", this.Health) : ", DEAD");
        }
    }
}
