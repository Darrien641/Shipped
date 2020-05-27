using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace ShippingApp
{
    static class Menu
    {
        static Shipper shipper = new Shipper();
        private static string[] MenuList = new string[]
        {
                "Add Bicycle to Shipment",
                "Add Lawn Mower to Shipment",
                "Add BaseBall Glove to Shipment",
                "Add Crackers to Shipment",
                "Display Shipment Manifest",
                "Compute Shipping Fees"
        };

        public static IEnumerable<string> GetMenu()
        {
            return MenuList;
            
        }


    }
}
