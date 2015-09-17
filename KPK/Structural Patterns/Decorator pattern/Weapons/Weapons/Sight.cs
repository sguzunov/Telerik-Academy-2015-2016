using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapons
{
    public class Sight : WeaponAccessory
    {
        public Sight(Weapon weapon)
            : base(weapon)
        {
            this.Weapon.Price += 100;
            this.Weapon.Weight += 0.100;
        }

        public override string Describe()
        {
            return base.Describe();
        }
    }
}
