using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapons
{
    public class Silencer : WeaponAccessory
    {
        public Silencer(Weapon weapon)
            : base(weapon)
        {
            this.Weapon.Price += 50M;
            this.Weapon.Weight += 0.2;
        }

        public override string Describe()
        {
            return base.Describe();
        }
    }
}
