namespace SweetShops.Cookies
{
    public class CoatedCookie : Cookie
    {
        private readonly string name = "Coated cookies";

        public CoatedCookie(string dough)
            : base(dough)
        {
        }

        public override string ToString()
        {
            return this.name + "." + base.ToString();
        }
    }
}
