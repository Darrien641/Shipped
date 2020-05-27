using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace ShippingApp
{
    class Shipper
    {
        List<IShippable> items = new List<IShippable>();

        public Shipper()
        {
        }
        public string Add(IShippable shippable)
        {
            items.Add(shippable);
            return "1 " + shippable.Product + " has been added\n";
        }
        public IEnumerable<IShippable> GetShippables()
        {
            return items;
        }
        public string PrintManifest()
        {
            string lm = string.Empty;
            string bc = string.Empty;
            string ckrs = string.Empty;
            string bg = string.Empty;
            if (GetBicycleCount() > 1)
            {
                bc = GetBicycleCount() + " Bicycles";
            }
            else
            {
                bc = GetBicycleCount() + " Bicycle";
            }
            if (GetBaseballGloveCount() > 1)
            {
                bg = GetBaseballGloveCount() + " Baseball Gloves";
            }
            else
            {
                bg = GetBaseballGloveCount() + " Baseball Glove";
            }
            if (GetLawnMowerCount() > 1)
            {
                lm = GetLawnMowerCount() + " Lawn Mowers";
            }
            else
            {
                lm = GetLawnMowerCount() + " Lawn Mower";
            }
            if (GetCrackersCount() >= 0)
            {
                ckrs = GetCrackersCount() + " Crackers";
            }

            return $"Shipment Manifest:\n{bc}\n{bg}\n{lm}\n{ckrs}\n";
        }
        public string GetShippingCost()
        {
            decimal total = 00.00m;
            foreach (IShippable shippable in items) 
            {
                    total += shippable.ShipCost;
            }
            return $"Total Shipping costs for this order is {total:$00.00}";
        }
        private int GetCrackersCount()
        {
            int crackers = 0;
            foreach (IShippable s in items)
            {
                if (s is Crackers)
                {
                    crackers++;
                }
            }

            return crackers;
        }
        private int GetBicycleCount()
        {
            int Bicycle = 0;
            foreach (IShippable s in items)
            {
                if (s is Bicycle)
                {
                    Bicycle++;
                }
            }
            return Bicycle;
        }
        private int GetLawnMowerCount()
        {
            int LawnMower = 0;
            foreach (IShippable s in items)
            {
                if (s is LawnMower)
                {
                    LawnMower++;
                }
            }
            return LawnMower;
        }
        private int GetBaseballGloveCount()
        {
            int Glove = 0;
            foreach (IShippable s in items)
            {
                if (s is BaseballGlove)
                {
                    Glove++;
                }
            }
            return Glove;
        }
    }
}
