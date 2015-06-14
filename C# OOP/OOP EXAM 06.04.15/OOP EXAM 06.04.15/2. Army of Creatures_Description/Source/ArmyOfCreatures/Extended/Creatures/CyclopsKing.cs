namespace ArmyOfCreatures.Extended.Creatures
{
    using System;

    using ArmyOfCreatures.Logic.Creatures;
    using ArmyOfCreatures.Logic.Specialties;
    using ArmyOfCreatures.Extended.Specialties;

    public class CyclopsKing : Creature
    {
        private const int BaseAttack = 17;
        private const int BaseDefence = 13;
        private const decimal BaseDamage = 18;
        private const int BaseHealth = 70;

        public CyclopsKing()
            : base(BaseAttack, BaseDefence, BaseHealth, BaseDamage)
        {
            this.AddSpecialty(new AddAttackWhenSkip(3));
            this.AddSpecialty(new DoubleAttackWhenAttacking(4));
            this.AddSpecialty(new DoubleDamage(1));
        }
    }
}
