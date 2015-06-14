namespace WarMachines.Machines
{
    using System.Text;
    using WarMachines.Interfaces;

    public class Tank : Machine , ITank , IMachine
    {
        private const int TankInitialHealthPoints = 100;
        private const int AttackChange = 40;
        private const int DefenceChange = 30;

        public Tank(string name, double attackPoints, double defensePoints)
            : base(name, attackPoints, defensePoints, TankInitialHealthPoints)
        {
            this.DefenseMode = true;
        }

        public bool DefenseMode { get; private set; }

        public void ToggleDefenseMode()
        {
            this.DefenseMode=!this.DefenseMode;

            if (this.DefenseMode)
            {
                this.AttackPoints -= AttackChange;
                this.DefensePoints += DefenceChange;
            }
            else
            {
                this.AttackPoints += AttackChange;
                this.DefensePoints -= DefenceChange;
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder(base.ToString());

            if (this.DefenseMode)
            {
                output.Append(" *Defense: ON\n");
            }
            else
            {
                output.Append(" *Defense: OFF\n");
            }

            return output.ToString();
        }
    }
}
