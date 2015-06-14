namespace ArmyOfCreatures.Extended.Creatures
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using ArmyOfCreatures.Logic.Creatures;

    public class Goblin : Creature
    {
        private const int GoblinAttack = 4;
        private const int GoblinDefence = 2;
        private const int GoblinHealthPoints = 5;
        private const decimal GoblinDamage = 1.5M;

        public Goblin()
            : base(GoblinAttack, GoblinDefence, GoblinHealthPoints, GoblinDamage)
        { 
        }
    }
}
