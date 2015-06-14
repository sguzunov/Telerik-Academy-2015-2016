﻿namespace TradeAndTravel
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Iron : Item
    {
        private const int IronValue = 3;

        public Iron(string name, Location location=null)
            : base(name, IronValue, ItemType.Iron, location)
        { 
        }
    }
}
