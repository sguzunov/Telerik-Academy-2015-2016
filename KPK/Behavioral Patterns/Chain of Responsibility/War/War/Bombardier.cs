namespace War
{
    using System;

    public class Bombardier : IAttackHandler
    {
        private readonly int hitPoints = 200;

        public IAttackHandler Successor { get; set; }

        public void AttackEnemy(ITarget enemy)
        {
            Console.WriteLine("{0} attacked {1}", this.GetType().Name, enemy.GetType().Name);
        }
    }
}
