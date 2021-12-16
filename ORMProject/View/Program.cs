using Core.Concrete;
using Core.DataAccess;
using DataAccess.Concrete.ORM;

using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace View
{
    class Program
    {
        static void Main(string[] args)
        {
            //OrmShipperDal ormShipperDal = new OrmShipperDal();
            //ormShipperDal.Context = new DbContext();

            //foreach (var item in ormShipperDal.Select())
            //{
            //    Console.WriteLine(item.CompanyName);
            //}
            //Shipper sp = new Shipper{ CompanyName = "Boring Company", Phone = "5554442", ShipperID = 3 };
            // ormShipperDal.Update(sp);
            //Shipper sp2 = new Shipper { CompanyName = "Boring Co", Phone = "5554442",ShipperID=12 };
            //ormShipperDal.Insert(sp2);
            //ormShipperDal.Delete(sp2);


            //            using Core.DataAccess.EntityFramework;
            //            using Entities.Concrete;
            //            using System;
            //            using System.Collections.Generic;
            //            using System.Linq;
            //            using System.Text;
            //            using System.Threading.Tasks;

            //namespace DataAccess.Concrete.ORM
            //    {
            //        public class OrmShipperDal : EfEntityRepositoryBase<Shipper, OrmShipperDal>
            //        {

            //        }




            //  namespace DataAccess.Concrete.ORM
            //    {
            //        public Class IAdressOrm : IEntityRepository<Adress>
            //    {
            //    }
            //}


            DirectoryInfo di = new DirectoryInfo(@"C:\Users\kbez1\Documents\kodlar\NA-203-Projects\ORMProject\DataAccess\Abstract\");
            FileInfo[] files = di.GetFiles("*.cs");
            List<string> listem = new List<string>();
            List<string> newFiles = new List<string>();
            foreach (var file in files)
            {
                string lines = "";
                IEnumerable<string> ıenm = File.ReadLines(file.FullName);
                string tur = file.Name.Substring(1, file.Name.IndexOf("Orm") - 1);

                string name = $"Orm{tur}Dal";

                // Console.WriteLine(name);

                
                foreach (string line in ıenm)
                {



                    lines += line + "\n";


                }
                int strt = lines.IndexOf("namespace");

                lines = lines.Substring(strt);
                lines = lines.Replace("interface", "class");
                lines = lines.Replace("DataAccess.Abstract", "DataAccess.Concrete.ORM");
               
                string degistir = "class "+ name+ " : IEntityRepository<"+tur+">";

                
                string each = "class "+name+": EfEntityRepositoryBase<"+tur+", "+name+">";
                
                string deneme = lines.Replace(degistir, each);
                
                Console.WriteLine(deneme);

                each = "";



                //listem.Add(lines);

            }

            //foreach (var item in listem)
            //{
            //    Console.WriteLine(item);
            //}

        }

    }
}
