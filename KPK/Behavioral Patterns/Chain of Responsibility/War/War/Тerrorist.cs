namespace War
{
    public class Тerrorist : ITarget
    {
        private readonly int defence = 60;

        public int Defence
        {
            get
            {
                return this.defence;
            }
        }
    }
}
