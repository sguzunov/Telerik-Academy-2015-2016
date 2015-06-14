namespace Cosmetics.Products
{
    using Cosmetics.Common;
    using Cosmetics.Contracts;
    using System.Text;

    public abstract class Product : IProduct
    {
        private const int MinNameLength = 3;
        private const int MaxNameLength = 10;
        private const int MinBrandLength = 2;
        private const int MaxBrandLength = 10;

        private string name;
        private string brand;

        public Product(string name, string brand,decimal price,GenderType gender)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Gender = gender;
        }

        public string Name
        {
            get 
            {
                return this.name;
            }
            protected set
            {                
                string stringNotNullOrEmpty = string.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty,"Product name");
                string stringMinMaxLength = string.Format(GlobalErrorMessages.InvalidStringLength, "Product name", MinNameLength, MaxNameLength);

                Validator.CheckIfStringIsNullOrEmpty(value, stringNotNullOrEmpty);
                Validator.CheckIfStringLengthIsValid(value, MaxNameLength, MinNameLength, stringMinMaxLength);

                this.name = value; 
            }
        }

        public string Brand
        {
            get
            {
                return this.brand;
            }
            protected set
            {
                string stringNotNullOrEmpty = string.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty,"Brand name");
                string stringMinMaxLength = string.Format(GlobalErrorMessages.InvalidStringLength, "Product brand", MinBrandLength, MaxBrandLength);

                Validator.CheckIfStringIsNullOrEmpty(value, stringNotNullOrEmpty);
                Validator.CheckIfStringLengthIsValid(value, MaxBrandLength, MinBrandLength, stringMinMaxLength);

                this.brand = value;
            }
        }

        public decimal Price { get; protected set; }

        public GenderType Gender { get; protected set; }

        public virtual string Print()
        {
            StringBuilder output = new StringBuilder();            

            output.AppendFormat("- {0} - {1}:\n", this.Brand, this.Name);
                        
            output.AppendFormat("  * Price: ${0}\n", this.Price);

            output.AppendFormat("  * For gender: {0}", this.Gender);

            return output.ToString();
        }
    }
}
