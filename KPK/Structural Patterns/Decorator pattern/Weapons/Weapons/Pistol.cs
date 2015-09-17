using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapons
{
    public class Pistol : Weapon
    {
        public Pistol()
        {
            this.Weight = 2.00;
            this.Range = 1000;
            this.Price = 200M;
        }

        public override string Describe()
        {
            var description = new StringBuilder();
            description.AppendLine("--Pistol--");
            description.AppendFormat("Weitght: {0}kg\n", this.Weight);
            description.AppendFormat("Range: {0}m\n", this.Range);
            description.AppendFormat("Price: ${0}", this.Price);

            return description.ToString();
        }
    }
}
