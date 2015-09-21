namespace SweetShops.Cookies
{
    public abstract class Cookie
    {
        public Cookie(string dough)
        {
            this.Dough = dough;
        }
        
        public string Dough { get; private set; }

        public override string ToString()
        {
            return "Made with " + this.Dough;
        }
    }
}
