namespace War
{
    public class Program
    {
        static void Main()
        {
            var ranker = new Ranker();
            var snipperist = new Snipperist();
            var bombardier = new Bombardier();

            ranker.Successor = snipperist;
            snipperist.Successor = bombardier;

            var terroristEnemy = new Тerrorist();
            var tankEnemy = new Tank();

            ranker.AttackEnemy(terroristEnemy);
            ranker.AttackEnemy(tankEnemy);
        }
    }
}
