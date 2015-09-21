namespace War
{
    using System;

    public class Snipperist : IAttackHandler
    {
        private readonly int hitPoints = 75;

        public IAttackHandler Successor { get; set; }

        public void AttackEnemy(ITarget enemy)
        {
            if (this.hitPoints > enemy.Defence)
            {
                Console.WriteLine("{0} attacked {1}", this.GetType().Name, enemy.GetType().Name);
            }
            else
            {
                if (this.Successor != null)
                {
                    this.Successor.AttackEnemy(enemy);
                }
            }
        }
    }
}
