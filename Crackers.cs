using System;
using System.Collections.Generic;
using System.Text;

namespace ShippingApp
{
    class Crackers : IShippable
    {
        
        public Crackers() 
        {
            ShipCost = .57M;
            Product = "Crackers";
        }
        
        public decimal ShipCost { get; }
        public string Product { get; }
    }
}
