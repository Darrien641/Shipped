using System;
using System.Collections.Generic;
using System.Text;

namespace ShippingApp
{
    class LawnMower : IShippable
    {
        public LawnMower()
        {
            ShipCost = 24.00M;
            Product = "Lawn Mower";
        }
        public decimal ShipCost { get; }
        public string Product { get; }
    }
}
