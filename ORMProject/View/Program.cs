using Core.Concrete;
using DataAccess.Concrete.ORM;

using Entities.Concrete;
using System;

namespace View
{
    class Program
    {
        static void Main(string[] args)
        {
            OrmShipperDal ormShipperDal = new OrmShipperDal();
            ormShipperDal.Context = new DbContext();

            //foreach (var item in ormShipperDal.Select())
            //{
            //    Console.WriteLine(item.CompanyName);
            //}
             //Shipper sp = new Shipper{ CompanyName = "Boring Company", Phone = "5554442", ShipperID = 3 };
            // ormShipperDal.Update(sp);
            //Shipper sp2 = new Shipper { CompanyName = "Boring Co", Phone = "5554442",ShipperID=12 };
            //ormShipperDal.Insert(sp2);
            //ormShipperDal.Delete(sp2);
        }
        
    }
}
