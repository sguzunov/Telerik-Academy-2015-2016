namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using WarMachines.Interfaces;

    public class Fighter : Machine,IFighter
    {
        private const int FighterHealthPoints=200;

        public Fighter(string name, double attackPoints, double defensePoints, bool stealthMode)
            : base(name, attackPoints, defensePoints, FighterHealthPoints)
        {
            this.StealthMode = stealthMode;
        }

        public bool StealthMode { get; private set; }

        public void ToggleStealthMode()
        {
            this.StealthMode = !this.StealthMode;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder(base.ToString());

            if (this.StealthMode)
            {
                output.Append(" *Stealth: ON\n");
            }
            else
            {
                output.Append(" *Stealth: OFF\n");
            }

            return output.ToString();
        }
    }
}
