namespace War
{
    public class Tank : ITarget
    {
        private readonly int defence = 100;

        public int Defence
        {
            get
            {
                return this.defence;
            }
        }
    }
}
