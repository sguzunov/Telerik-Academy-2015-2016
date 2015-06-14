namespace ArmyOfCreatures.Extended.Creatures
{
    using ArmyOfCreatures.Logic.Creatures;
    using ArmyOfCreatures.Logic.Specialties;

    public class Griffin : Creature
    {
        private const int BaseAttack = 8;
        private const int BaseDefence = 8;
        private const decimal BaseDemage = 4.5m;
        private const int BaseHealth = 25;        

        public Griffin()
            : base(BaseAttack, BaseDefence, BaseHealth, BaseDemage)
        {
            this.AddSpecialty(new DoubleDefenseWhenDefending(5));
            this.AddSpecialty(new AddDefenseWhenSkip(3));
            this.AddSpecialty(new Hate(typeof(WolfRaider)));
        }
    }
}
