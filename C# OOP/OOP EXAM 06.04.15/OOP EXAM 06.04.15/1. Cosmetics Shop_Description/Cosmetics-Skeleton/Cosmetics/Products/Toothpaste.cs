namespace Cosmetics.Products
{
    using System;
    using Cosmetics.Common;
    using Cosmetics.Contracts;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;

    public class Toothpaste : Product , IToothpaste, IProduct
    {
        private const int MinIngredientsNameLength = 4;
        private const int MaxIngredientsNameLength = 12;

        private readonly IList<string> ingredients;

        public Toothpaste(string name, string brand, decimal price, GenderType gender, IList<string> ingredients)
            : base(name, brand, price, gender)
        {
            ValidateIngredients(ingredients);
            this.ingredients = ingredients;
        }

        public string Ingredients
        {
            get
            {
                return string.Join(", ", this.ingredients);
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder(base.Print());
                        
            output.AppendFormat("\n  * Ingredients: {0} ", string.Join(", ", this.Ingredients));

            return output.ToString();
        }

        private void ValidateIngredients(IList<string> ingredients)
        {
            if (ingredients.Any(i => i.Length < MinIngredientsNameLength || i.Length > MaxIngredientsNameLength))
            {
                throw new ArgumentException(string.Format(GlobalErrorMessages.InvalidStringLength, "Each ingredient", MinIngredientsNameLength, MaxIngredientsNameLength));
            }

        }
    }    
}
