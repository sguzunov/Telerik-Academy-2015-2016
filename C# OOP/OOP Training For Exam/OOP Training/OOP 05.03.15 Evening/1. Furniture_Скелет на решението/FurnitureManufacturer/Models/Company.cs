namespace FurnitureManufacturer.Models
{
    using FurnitureManufacturer.Interfaces;
    using FurnitureManufacturer.Common;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Company : ICompany
    {
        private string name;
        private string registrationNumber;
        private ICollection<IFurniture> furnitures;

        public Company(string name, string registrationNumber)
        {
            this.Name = name;
            this.RegistrationNumber = registrationNumber;
            this.furnitures = new List<IFurniture>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                Validator.IsValidString(value, 5, "The name of company cannot be null , empty space or it's lenth must e more than 5 symbols.");
                this.name = value;
            }
        }

        public string RegistrationNumber
        {
            get
            {
                return this.registrationNumber;
            }
            private set
            {
                Validator.IsValidRegistrationNumber(value, "The registration number must contains only digits and it's length must be 10 symbols.");
                this.registrationNumber = value;
            }
        }

        public ICollection<IFurniture> Furnitures
        {
            get { return this.furnitures; }
        }

        public void Add(IFurniture furniture)
        {
            this.furnitures.Add(furniture);
        }

        public void Remove(IFurniture furniture)
        {
            this.furnitures.Remove(furniture);
        }

        public IFurniture Find(string model)
        {
            return this.furnitures.FirstOrDefault(f => f.Model.ToLower() == model.ToLower());

        }

        public string Catalog()
        {
            StringBuilder output = new StringBuilder();
            var sortedFurnitures = this.furnitures.OrderBy(f => f.Price).ThenBy(f => f.Model);

            output.AppendFormat("{0} - {1} - {2} {3}", this.Name, this.RegistrationNumber,
                this.Furnitures.Count != 0 ? this.Furnitures.Count.ToString() : "no",
                this.Furnitures.Count != 1 ? "furnitures" : "furniture");

            foreach (var fur in sortedFurnitures)
            {
                output.AppendLine(fur.ToString());
            }

            return output.ToString();
        }
    }
}
