namespace ArmyOfCreatures.Extended.Creatures
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using ArmyOfCreatures.Logic.Creatures;
    using ArmyOfCreatures.Logic.Specialties;

    public class AncientBehemoth : Creature
    {
        private const int BaseAttack = 19;
        private const int BaseDefence = 19;
        private const decimal BaseDemage = 40;
        private const int BaseHealth = 300;

        public AncientBehemoth()
            : base(BaseAttack, BaseDefence, BaseHealth, BaseDemage)
        {
            this.AddSpecialty(new ReduceEnemyDefenseByPercentage(80));
            this.AddSpecialty(new DoubleDefenseWhenDefending(5));
        }
    }
}
