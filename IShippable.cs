using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ShippingApp
{
    public interface IShippable
    {
        
        decimal ShipCost { get; }
        string Product { get; }


    }
}
