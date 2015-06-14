namespace Infestation
{
    using System.Linq;

    public class Marine : Human
    {
        public Marine(string id)
            : base(id)
        {
            this.AddSupplement(new WeaponrySkill());
        }

        protected override bool CanAttackUnit(UnitInfo unit)
        {
            if (unit.Power <= this.Power)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        protected override UnitInfo GetOptimalAttackableUnit(System.Collections.Generic.IEnumerable<UnitInfo> attackableUnits)
        {
            return attackableUnits.OrderBy(u => u.Health).LastOrDefault();
        }
    }
}
