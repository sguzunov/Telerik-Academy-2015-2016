namespace FarmersCreed.Units
{
    using System;
    using System.Collections.Generic;
    using FarmersCreed.Interfaces;
    using System.Linq;
    using System.Text;

    public class Farm : GameObject, IFarm
    {      
        public Farm(string id)
            : base(id)
        {
            this.Plants = new List<Plant>();
            this.Animals = new List<Animal>();
            this.Products = new List<Product>();
        }

        public List<Plant> Plants { get; set; }

        public List<Animal> Animals { get; set; }

        public List<Product> Products { get; set; }

        public void AddProduct(Product product)
        {
            var existingProduct = this.Products.FirstOrDefault(p => p.Id == product.Id);

            if (existingProduct != null)
            {
                existingProduct.Quantity += product.Quantity;
            }
            else
            {
                this.Products.Add(product);
            }
        }

        public void Exploit(IProductProduceable productProducer)
        {
            var product = productProducer.GetProduct();
            this.Products.Add(product);
        }

        public void Feed(Animal animal, IEdible edibleProduct, int productQuantity)
        {
            animal.Eat(edibleProduct, productQuantity);
        }

        public void Water(Plant plant)
        {
            plant.Water();
        }

        public void UpdateFarmState()
        {
            foreach (var plant in this.Plants)
            {
                if (plant.HasGrown == false)
                {
                    plant.Grow();
                }
                if (plant.HasGrown == true && plant.IsAlive)
                {
                    plant.Wither();
                }
            }

            foreach (var animal in this.Animals)
            {
                if (animal.IsAlive)
                {
                    animal.Starve();
                }                
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendFormat(base.ToString());

            var sortedAnimals = this.Animals.Where(a => a.IsAlive).OrderBy(a => a.Id);

            var sortedPlants = this.Plants.Where(a => a.IsAlive).OrderBy(a => a.Health).ThenBy(a => a.Id);

            var sortedProducts = this.Products.OrderBy(a => a.ProductType).ThenByDescending(a => a.Quantity).ThenBy(a => a.Id);

            foreach (var animal in sortedAnimals)
            {
                result.AppendLine(animal.ToString());
            }

            foreach (var plant in sortedPlants)
            {
                result.AppendLine(plant.ToString());
            }

            foreach (var product in this.Products)
            {
                result.AppendLine(product.ToString());
            }

            return result.ToString();
        }
    }
}
