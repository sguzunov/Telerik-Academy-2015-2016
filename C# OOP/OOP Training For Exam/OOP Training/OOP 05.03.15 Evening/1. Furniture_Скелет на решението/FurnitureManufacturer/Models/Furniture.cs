namespace FurnitureManufacturer.Models
{
    using System;
    using FurnitureManufacturer.Interfaces;
    using FurnitureManufacturer.Common;

    public class Furniture : IFurniture
    {
        private string model;
        private decimal price;
        private decimal height;

        public Furniture(string model, MaterialType materialType, decimal price, decimal heigth)
        {
            this.Model = model;
            this.MaterialType = materialType;
            this.Price = price;
            this.Height = height;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            protected set
            {
                Validator.IsValidString(value, 3, "The name cannot be null or empty space and it's length must be more than 3 symbols.");
                this.model = value;
            }
        }

        public string Material { get; protected set; }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                Validator.IsValidDecimal(value, "The price cannot be equal or less than 0.0.");
                this.price = value;
            }
        }

        public virtual decimal Height
        {
            get
            {
                return this.height;
            }
            protected set
            {
                Validator.IsValidDecimal(value, "The height cannot be equal or less than 0.0.");
                this.height = value;
            }
        }
        protected MaterialType MaterialType { get; set; }
    }
}
