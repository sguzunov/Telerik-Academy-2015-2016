namespace SweetShops.Cookies
{
    public class SweetCookie : Cookie
    {
        private readonly string name = "Sweet cookies";

        public SweetCookie(string dough)
            : base(dough)
        {
        }

        public override string ToString()
        {
            return this.name + "." + base.ToString();
        }
    }
}
