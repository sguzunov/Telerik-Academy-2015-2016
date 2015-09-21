namespace War
{
    public interface IAttackHandler
    {
        IAttackHandler Successor { get; set; }

        void AttackEnemy(ITarget enemy);
    }
}
