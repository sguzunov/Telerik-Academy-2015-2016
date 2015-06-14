namespace FarmersCreed.Units
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Plant : FarmUnit
    {
        private int growTime;

        public Plant(string id, int health, int productionQuantity, int growTime)
            : base(id, health, productionQuantity)
        {
            this.GrowTime = growTime;
        }

        public virtual bool HasGrown
        {
            get
            {
                return this.GrowTime <= 0;
            }
        }

        public virtual int GrowTime
        {
            get 
            {
                return this.growTime;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The grow time cannot be < 0.");
                }

                this.growTime = value;
            }
        }

        public virtual void Water()
        {
            this.Health += 2;
        }

        public virtual void Wither()
        {
            this.Health--;
        }

        public virtual void Grow()
        {
            this.GrowTime--;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            if (this.IsAlive)
            {
                output.AppendFormat(", Grown: {0}", this.HasGrown ? "Yes" : "No");
            }

            return base.ToString() + output.ToString();
        }
    }
}
