namespace Cosmetics.Products
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Cosmetics.Common;
    using Cosmetics.Contracts;

    public class Shampoo : Product , IShampoo
    {
        public Shampoo(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usageType)
            : base(name, brand, price, gender)
        {
            this.Milliliters = milliliters;
            this.Usage = usageType;
            this.Price *= this.Milliliters;
        }        

        public uint Milliliters { get; private set; }

        public UsageType Usage { get; private set; }

        public override string Print()
        {
            StringBuilder output = new StringBuilder();

            output.AppendFormat(base.Print());

            output.AppendFormat("\n  * Quantity: {0} ml", this.Milliliters);

            output.AppendFormat("  * Usage: {0}", this.Usage);

            return output.ToString();            
        }
    }
}
