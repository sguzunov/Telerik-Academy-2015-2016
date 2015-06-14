namespace ArmyOfCreatures.Extended
{
    using ArmyOfCreatures.Logic;
    using ArmyOfCreatures.Extended.Creatures;

    public class ExtendedCreatureFactory : CreaturesFactory
    {
        public override Logic.Creatures.Creature CreateCreature(string name)
        {
            switch (name)
            {
                case "AncientBehemoth":
                    return new AncientBehemoth();
                case "CyclopsKing":
                    return new CyclopsKing();
                case "Goblin":
                    return new CyclopsKing();
                case "Griffin":
                    return new Griffin();
                case "WolfRaider":
                    return new Griffin();
                default:
                    {
                        return base.CreateCreature(name);
                    }
            }           
        }
    }
}
