using System;
using System.Collections.Generic;
using System.Linq;

namespace ShippingApp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Shipper shipper = new Shipper();
            int Selection;
            

            do
            {
                int MenuCount = 1;
                foreach (string Item in Menu.GetMenu())
                {
                    Console.WriteLine(MenuCount++ + ". " + Item);
                }
                Console.WriteLine();
                Selection = int.Parse(Console.ReadLine());

                

                if (Selection == 1)
                {
                    Console.WriteLine(shipper.Add(new Bicycle()));
                    
                }
                if (Selection == 2)
                {
                    Console.WriteLine(shipper.Add(new LawnMower()));
                }
                if (Selection == 3)
                {
                    Console.WriteLine(shipper.Add(new BaseballGlove()));
                }
                if (Selection == 4)
                {
                    Console.WriteLine(shipper.Add(new Crackers()));
                }
                if (Selection == 5)
                {
                    Console.WriteLine();
                    Console.WriteLine(shipper.PrintManifest());
                }
                if (Selection == 6)
                {
                    Console.WriteLine(shipper.GetShippingCost());
                }
            } while (Selection >= 0 && Selection <= 6);

        }
    }
}
