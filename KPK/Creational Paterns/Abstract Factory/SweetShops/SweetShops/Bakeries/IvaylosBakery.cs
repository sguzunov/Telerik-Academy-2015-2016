namespace SweetShops.Bakeries
{
    using SweetShops.Cookies;

    public class IvaylosBakery : Bakery
    {
        private const string DOUGH = "unleavened";

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
