namespace SweetShops.Bakeries
{
    using SweetShops.Cookies;

    public class DonchosBakery : Bakery
    {
        private const string DOUGH = "leavened";

        public override Cookie CreateCrackerCookie()
        {
            return new CrackerCookie(DOUGH);
        }

        public override Cookie CreateSweetCookie()
        {
            return new SweetCookie(DOUGH);
        }

        public override Cookie CreateCoatedCookie()
        {
            return new CoatedCookie(DOUGH);
        }
    }
}
