using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuConstructor
{
    public class Menu
    {
        private readonly Dictionary<string, string> products = new Dictionary<string, string>();

        public Menu(string type)
        {
            this.Type = type;
        }

        public string this[string key]
        {
            get
            {
                return this.products[key];
            }

            set
            {
                this.products[key] = value;
            }
        }

        public string Type { get; set; }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.AppendFormat("{0} menu.", this.Type);

            foreach (var product in products)
            {
                result.AppendFormat("{0} ==> {1}", product.Key, product.Value);
            }

            return result.ToString();
        }
    }
}
