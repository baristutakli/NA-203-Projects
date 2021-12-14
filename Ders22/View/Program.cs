using System;
using ORM;
using Entities;
using System.Collections.Generic;

namespace View
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //CategoriesORM orm = new CategoriesORM();
            //List<Categories> kategoriler = orm.Select();
            //foreach (var item in kategoriler)
            //{
            //    Console.WriteLine(item.CategoryID+" "+item.CategoryName);
            //}

            //ShippersORM sorm = new ShippersORM();
            //List<Shippers> shipperList = sorm.Select();

            //foreach (var item in shipperList)
            //{
            //    Console.WriteLine(item.CompanyName);
            //}
            //Categories ctg = new Categories();
            //ctg.CategoryID = 11;
            //ctg.CategoryName = "Foods";
            //ctg.Description = "Food category detail Güncel";
            //ctg.Picture = null;
            //CategoriesORM.Current.Update(ctg);

            // Categories ct = CategoriesORM.Current.Select(11);

            List<Shippers> shList = ShippersORM.Current.Select();
            foreach (var sh in shList)
            {
                Console.WriteLine(sh.ShipperId + " " + sh.CompanyName);
            }
            Console.Write("ID seç:");
            int id = Convert.ToInt32(Console.ReadLine());
            Shippers shd = ShippersORM.Current.Select(id);
            shd.CompanyName = "GİRESUN TAŞIMACILIK";
            ShippersORM.Current.Update(shd);
            shList = ShippersORM.Current.Select();
            foreach (var sh in shList)
            {
                Console.WriteLine(sh.ShipperId + " " + sh.CompanyName);
            }

        }
    }
}
