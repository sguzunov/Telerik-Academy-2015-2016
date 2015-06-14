namespace ArmyOfCreatures.Extended.Creatures
{
    using ArmyOfCreatures.Extended.Specialties;
    using ArmyOfCreatures.Logic.Creatures;
    
    public class WolfRaider : Creature
    {
        private const int BaseAttack = 8;
        private const int BaseDefence = 5;
        private const int BaseHealth = 10;
        private const decimal BaseDemage = 3.5m;

        public WolfRaider()
            : base(BaseAttack, BaseDefence, BaseHealth, BaseDemage)
        {
            this.AddSpecialty(new DoubleDamage(7));
        }
    }
}
