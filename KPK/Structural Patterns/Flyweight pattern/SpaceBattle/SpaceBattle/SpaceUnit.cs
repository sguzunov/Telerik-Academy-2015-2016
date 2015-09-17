namespace SpaceBattle
{
    public abstract class SpaceUnit
    {
        public int HitPonts { get; set; }

        public int Live { get; set; }

        public abstract void Attack(TargetUnit target);
    }
}
