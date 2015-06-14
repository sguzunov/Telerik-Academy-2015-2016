﻿namespace Infestation
{
    public class Tank : Unit
    {
        private const int BasePower = 25;
        private const int BaseHealth = 20;
        private const int BaseAggression = 25;

        public Tank(string id)
            : base(id, UnitClassification.Mechanical, BaseHealth, BasePower, BaseAggression)
        { 
        }
    }
}
