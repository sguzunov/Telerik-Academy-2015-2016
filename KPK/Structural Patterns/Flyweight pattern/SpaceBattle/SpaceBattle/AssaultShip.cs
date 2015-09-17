namespace SpaceBattle
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class AssaultShip : SpaceUnit
    {
        public AssaultShip()
        {
            this.HitPonts = 65;
            this.Live = 90;
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
