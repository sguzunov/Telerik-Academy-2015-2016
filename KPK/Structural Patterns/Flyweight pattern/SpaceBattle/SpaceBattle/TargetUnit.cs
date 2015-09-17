namespace SpaceBattle
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TargetUnit
    {
        public TargetUnit(int live)
        {
            this.Live = live;
            this.Demage = 40;
        }

        public int Demage { get; set; }

        public int Live { get; set; }
    }
}
