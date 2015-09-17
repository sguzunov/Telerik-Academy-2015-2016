namespace Weapons
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Rifle : Weapon
    {
        public Rifle()
        {
            this.Weight = 8.00;
            this.Range = 1500;
            this.Price = 1400M;
        }
        public override string Describe()
        {
            var description = new StringBuilder();
            description.AppendLine("--Rifle--");
            description.AppendFormat("Weitght: {0}kg\n", this.Weight);
            description.AppendFormat("Range: {0}m\n", this.Range);
            description.AppendFormat("Price: ${0}", this.Price);

            return description.ToString();
        }
    }
}
