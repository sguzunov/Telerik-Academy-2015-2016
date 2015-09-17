namespace SpaceBattle
{
    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            var factory = new UnitsFactory();
            var cruiser = factory.CreateUnit("PatrolCruiser");
            var destroyer = factory.CreateUnit("StarDestroyer");

            var evilShip = new TargetUnit(90);
            var evilCruiser = new TargetUnit(50);

            cruiser.Attack(evilShip);
            destroyer.Attack(evilCruiser);
        }
    }
}
