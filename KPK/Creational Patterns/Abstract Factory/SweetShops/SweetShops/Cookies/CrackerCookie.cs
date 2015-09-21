namespace SweetShops.Cookies
{
    public class CrackerCookie : Cookie
    {
        private readonly string name = "Crackers cookies";

        public CrackerCookie(string dough)
            : base(dough)
        {
        }

        public override string ToString()
        {
            return this.name + "." + base.ToString();
        }
    }
}
