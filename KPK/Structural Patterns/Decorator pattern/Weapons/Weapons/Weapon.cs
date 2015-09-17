namespace Weapons
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Weapon
    {
        public double Weight { get; set; }

        public double Range { get; set; }

        public decimal Price { get; set; }

        public abstract string Describe();
    }
}
