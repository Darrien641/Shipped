using System;
using System.Collections.Generic;
using System.Text;

namespace ShippingApp
{
    class BaseballGlove : IShippable
    {
        public BaseballGlove()
        {
            ShipCost = 3.23M;
            Product = "BaseBall Glove";
        }
        public decimal ShipCost { get; }
        public string Product { get; }
    }
}
