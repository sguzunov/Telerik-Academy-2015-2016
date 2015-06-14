namespace AcademyEcosystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Zombie : Animal
    {
        private const int ZombieSize = 0;
        private const int MeatUnit = 10;

        public Zombie(string name, Point location)
            : base(name, location, ZombieSize)
        { 
        }

        public override int GetMeatFromKillQuantity()
        {
            return MeatUnit;
        }
    }
}
