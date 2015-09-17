namespace Weapons
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class WeaponAccessory : Weapon
    {
        public WeaponAccessory(Weapon weapon)
        {
            this.Weapon = weapon;
        }

        public Weapon Weapon { get; set; }

        public override string Describe()
        {
            string description = this.Weapon.Describe();
            return description;
        }
    }
}
