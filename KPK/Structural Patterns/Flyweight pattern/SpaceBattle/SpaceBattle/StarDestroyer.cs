namespace SpaceBattle
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StarDestroyer : SpaceUnit
    {
        public StarDestroyer()
        {
            this.HitPonts = 100;
            this.Live = 70;
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
