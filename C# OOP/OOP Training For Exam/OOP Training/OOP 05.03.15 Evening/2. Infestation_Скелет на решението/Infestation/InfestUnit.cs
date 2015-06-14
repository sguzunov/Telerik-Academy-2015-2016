namespace Infestation
{
    public class InfestUnit :Unit
    {
        public InfestUnit(string id, UnitClassification unitType, int health, int power, int aggression)
            : base(id, unitType, health, power, aggression)
        { 
        }

        protected override UnitInfo GetOptimalAttackableUnit(System.Collections.Generic.IEnumerable<UnitInfo> attackableUnits)
        {
            return base.GetOptimalAttackableUnit(attackableUnits);
        }
    }
}
