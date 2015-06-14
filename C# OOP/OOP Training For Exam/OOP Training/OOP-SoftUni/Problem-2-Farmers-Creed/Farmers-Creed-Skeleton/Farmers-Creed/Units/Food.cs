﻿namespace FarmersCreed.Units
{
    using System;
    using FarmersCreed.Interfaces;

    public class Food : Product, IEdible
    {
        private FoodType foodType;
        private int healthEffect;

        public Food(string id, ProductType productType, FoodType foodType, int quantity, int healthEffect)
            : base(id, productType, quantity)
        {
            this.HealthEffect = healthEffect;
            this.FoodType = foodType;
        }

        public FoodType FoodType
        {
            get { return this.foodType; }
            set { this.foodType = value;  }
        }

        public int HealthEffect
        {
            get { return this.healthEffect; }
            set { this.healthEffect = value; }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(", Food Type: {0}, Health Effect: {1}", this.FoodType, this.HealthEffect);
        }
    }
}
