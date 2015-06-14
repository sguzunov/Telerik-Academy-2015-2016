namespace Cosmetics.Products
{
    using Cosmetics.Common;
    using Cosmetics.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Category : ICategory
    {
        private const int MinNameLength = 2;
        private const int MaxNameLength = 15;

        private string name;
        private ICollection<IProduct> products;

        public Category(string name)
        {
            this.Name = name;
            this.products = new List<IProduct>();
        }

        public string Name
        {
            get 
            {
                return this.name;
            }
            private set
            {
                string stringNotNullOrEmpty = string.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, this.GetType().Name);
                string stringMinMaxLength = string.Format(GlobalErrorMessages.InvalidStringLength, this.GetType().Name + " name", MinNameLength, MaxNameLength);

                Validator.CheckIfStringIsNullOrEmpty(value, stringNotNullOrEmpty);
                Validator.CheckIfStringLengthIsValid(value, MaxNameLength, MinNameLength, stringMinMaxLength);

                this.name = value;                
            }
        }
        
        public void AddCosmetics(IProduct cosmetics)
        {
            string objNotNull=string.Format(GlobalErrorMessages.ObjectCannotBeNull,"Product");

            Validator.CheckIfNull(cosmetics, objNotNull);

            this.products.Add(cosmetics);
        }

        public void RemoveCosmetics(IProduct cosmetics)
        {
            if (!products.Contains(cosmetics))
            { 
                string productNotFound=string.Format("Product {0} does not exist in category {1}!",cosmetics.Name,cosmetics.GetType().Name);

                throw new InvalidOperationException(productNotFound);
            }

            this.products.Remove(cosmetics);
        }

        public string Print()
        {
            StringBuilder output = new StringBuilder();

            var sortedProducts = this.products.OrderBy(p => p.Brand).ThenByDescending(p => p.Price);

            output.AppendFormat("{0} category - ", this.Name);

            if (this.products.Count == 1)
            {
                output.Append(this.products.Count + " product in total");
            }
            else
            {
                output.Append(this.products.Count + " products in total");
            }                      

            foreach (var product in sortedProducts)
            {
                output.AppendLine(product.Print());
            }

            return output.ToString().Trim();
        }
    }
}
