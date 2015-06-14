﻿namespace AcademyEcosystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Boar : Animal , ICarnivore,IHerbivore
    {
        private const int BoarSize = 4;
        private const int BoarBiteSize = 2;

        public Boar(string name, Point position)
            : base(name, position, BoarSize)
        { 
        }

        public int TryEatAnimal(Animal animal)
        {
            if (animal != null)
            {
                if (animal.Size <= this.Size)
                {
                    return animal.GetMeatFromKillQuantity();
                }
            }

            return 0;
        }
        
        public int EatPlant(Plant plant)
        {
            if (plant != null)
            {
                this.Size += 1;
                return plant.GetEatenQuantity(BoarBiteSize);
            }

            return 0;
        }
    }
}
