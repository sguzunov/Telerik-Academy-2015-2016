namespace War
{
    using System;

    public class Ranker : IAttackHandler
    {
        private readonly int hitPoints = 50;

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
