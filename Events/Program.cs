using System;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Product Hdd = new Product(50);
            Hdd.ProductName = "Hard disk";

            Product ssd = new Product(50);
            ssd.ProductName = "Ssd";
            ssd.StockControlEvent += Ssd_StockControlEvent;
            for (int i = 0; i < 10; i++)
            {
                Hdd.Sell(10);
                ssd.Sell(10);

            }
        
        }
        private static void Ssd_StockControlEvent()
        {
            Console.WriteLine("SSd about to finish");
        }
    }
}
