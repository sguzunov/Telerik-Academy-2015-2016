namespace SpaceBattle
{
    using System;

    public class PatrolCruiser : SpaceUnit
    {
        public PatrolCruiser()
        {
            this.HitPonts = 50;
            this.Live = 100;
        }

        public override void Attack(TargetUnit target)
        {
            target.Live -= this.HitPonts;
            if (target.Live < 0)
            {
                target.Live = 0;
            }

            Console.WriteLine("{0} attacked {1} and left it with {2} live.", this.GetType(), target.GetType(), target.Live);
        }
    }
}
