namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using WarMachines.Interfaces;

    public class Pilot : IPilot
    {
        private List<IMachine> machines;
        private string name;

        public Pilot(string name)
        {
            this.Name = name;
            this.machines = new List<IMachine>();
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
                    throw new ArgumentNullException("Incorrect input data.The value of the name CANNOT be null.");
                }

                this.name = value;
            }
        }

        public void AddMachine(IMachine machine)
        {
            if (machine == null)
            {
                throw new ArgumentNullException("Incorrect input data.Cannot add null in mashines.");
            }

            this.machines.Add(machine);
        }

        public string Report()
        {
            StringBuilder output = new StringBuilder();

            var sortedMachines = this.machines.OrderBy(m => m.HealthPoints).ThenBy(m => m.Name);

            output.AppendFormat("{0} - ",this.Name);

            if (this.machines.Count == 0)
            {
                output.Append("no machines");
            }
            if (this.machines.Count == 1)
            {
                output.Append("1 machine\n");
                output.Append(machines[0].ToString());
            }
            if (this.machines.Count > 1)
            {
                output.AppendFormat("{0} machines\n", this.machines.Count);
                foreach (var machine in sortedMachines)
                {                    
                    output.Append(machine.ToString());
                }
            }

            return output.ToString();
        }
    }
}
