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
            string MenuReturn = "Press any key to return to the menu";

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
                    Console.WriteLine(MenuReturn);
                    Console.ReadKey();
                }
                if (Selection == 2)
                {
                    Console.WriteLine(shipper.Add(new LawnMower()));
                    Console.WriteLine(MenuReturn);
                    Console.ReadKey();
                }
                if (Selection == 3)
                {
                    Console.WriteLine(shipper.Add(new BaseballGlove()));
                    Console.WriteLine(MenuReturn);
                    Console.ReadKey();
                }
                if (Selection == 4)
                {
                    Console.WriteLine(shipper.Add(new Crackers()));
                    Console.WriteLine(MenuReturn);
                    Console.ReadKey();
                }
                if (Selection == 5)
                {
                    Console.WriteLine();
                    Console.WriteLine(shipper.PrintManifest());
                }
                if (Selection == 6)
                {
                    Console.WriteLine(shipper.GetShippingCost());
                    Console.WriteLine("Press Any key to Exit");
                    Console.ReadKey();
                }
                Console.WriteLine();
            } while (Selection >= 0 && Selection < 6);

        }
    }
}
