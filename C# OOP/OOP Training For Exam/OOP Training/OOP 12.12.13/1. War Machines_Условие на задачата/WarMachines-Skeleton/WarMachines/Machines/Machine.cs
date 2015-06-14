namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using WarMachines.Interfaces;

    public abstract class Machine : IMachine
    {
        private string name;
        private IList<string> targets;
        private IPilot pilot;

        public Machine(string name, double attackPoints, double defensePoints,double healthPoints)
        {
            this.Name = name;
            this.AttackPoints = attackPoints;
            this.DefensePoints = defensePoints;
            this.HealthPoints = healthPoints;
            this.targets = new List<string>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value", "The name CANNOT  be null");
                }

                this.name = value;
            }
        }

        public IPilot Pilot
        {
            get
            {
                return this.pilot;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The pilot CANOT be null");
                }

                this.pilot = value;
            }
        }

        public double HealthPoints { get; set; }

        public double AttackPoints { get; protected set; }

        public double DefensePoints { get; protected set; }

        public IList<string> Targets
        {
            get { return new List<string>(this.targets); }
        }

        public void Attack(string target)
        {
            if (string.IsNullOrEmpty(target))
            {
                throw new ArgumentNullException("No target can be null");
            }

            this.Targets.Add(target);
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            output.AppendFormat("- {0}\n", this.Name);

            output.AppendFormat(" *Type: {0}\n", this.GetType().Name);

            output.AppendFormat(" *Health: {0}\n", this.HealthPoints);

            output.AppendFormat(" *Attack: {0}\n", this.AttackPoints);

            output.AppendFormat(" *Defense: {0}\n", this.DefensePoints);

            if (this.Targets.Count == 0)
            {
                output.Append(" *Targets: None\n");
            }
            else
            {
                output.AppendFormat(" *Targets: {0}\n", string.Join(", ", this.targets));
            }

            return output.ToString();
        }
    }
}
