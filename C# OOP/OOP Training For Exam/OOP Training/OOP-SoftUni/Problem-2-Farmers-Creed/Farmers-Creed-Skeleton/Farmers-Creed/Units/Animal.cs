namespace FarmersCreed.Units
{
    using System;
    using FarmersCreed.Interfaces;

    public abstract class Animal : FarmUnit
    {
        private const int IncreaseHealth = 1;

        public Animal(string id, int health, int productionQuantity)
            : base(id, health, productionQuantity)
        {
        }
        
        public virtual void Eat(IEdible food, int quantity)
        { 
        }

        public virtual void Starve()
        {
            this.Health -= IncreaseHealth;
        }        
    }
}
