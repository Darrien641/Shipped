using System;
using System.Collections.Generic;
using System.Text;

namespace ShippingApp
{
    class Bicycle : IShippable
    {
        public static int Count = 0;
        public Bicycle()
        {
            ShipCost = 20.50M;
            Product = "Bicycle";
        }

        public decimal ShipCost { get; }
        public string Product { get; }
    }
}
