namespace SpaceBattle
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class UnitsFactory
    {
        private Dictionary<string, SpaceUnit> units = new Dictionary<string, SpaceUnit>();

        public SpaceUnit CreateUnit(string name)
        {
            SpaceUnit unit = null;
            if (units.ContainsKey(name))
            {
                return units[name];
            }
            else
            {
                switch (name)
                {
                    case "AssaultShip":
                        {
                            unit = new AssaultShip();
                            break;
                        }
                    case "PatrolCruiser":
                        {
                            unit = new PatrolCruiser();
                            break;
                        }
                    case "StarDestroyer":
                        {
                            unit = new StarDestroyer();
                            break;
                        }
                }
            }

            units.Add(name, unit);

            return unit;
        }
    }
}
