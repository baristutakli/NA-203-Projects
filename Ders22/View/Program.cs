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
           
            ShippersORM sorm = new ShippersORM();
            List<Shippers> shipperList = sorm.Select();

            foreach (var item in shipperList)
            {
                Console.WriteLine(item.CompanyName);
            }

        }
    }
}
