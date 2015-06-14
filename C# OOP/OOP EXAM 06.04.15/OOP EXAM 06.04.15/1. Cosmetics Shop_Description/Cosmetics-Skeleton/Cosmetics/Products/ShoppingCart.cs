namespace Cosmetics.Products
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Cosmetics.Common;
    using Cosmetics.Contracts;

    public class ShoppingCart : IShoppingCart
    {
        private IList<IProduct> products;

        public ShoppingCart()
        {
            this.products = new List<IProduct>();
        }

        public void AddProduct(IProduct product)
        {
            string objNotNull = string.Format(GlobalErrorMessages.ObjectCannotBeNull, "Product");

            Validator.CheckIfNull(product, objNotNull);

            this.products.Add(product);
        }

        public void RemoveProduct(IProduct product)
        {
            this.products.Remove(product);
        }

        public bool ContainsProduct(IProduct product)
        {
            if (this.products.Contains(product))
            {
                return true;
            }

            return false;
        }

        public decimal TotalPrice()
        {
            return this.products.Sum(p => p.Price);
        }
    }
}
