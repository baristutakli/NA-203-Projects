using Core.Concrete;
using Core.DataAccess;
//using DataAccess.Concrete.ORM;

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




    


            DirectoryInfo di = new DirectoryInfo(@"C:\Users\kbez1\Documents\kodlar\NA-203-Projects\ORMProject\DataAccess\Abstract\");
            string path = @"C:\Users\kbez1\Documents\kodlar\NA-203-Projects\ORMProject\DataAccess\Concrete\ORM\";
            FileInfo[] files = di.GetFiles("*.cs");
            List<string> listem = new List<string>();
            List<string> newFiles = new List<string>();
            string needs = "using Core.DataAccess.EntityFramework;\n" + "using Entities.Concrete;\n" + "using System;\n";
            

            foreach (var file in files)
            {
                string lines = "";
                IEnumerable<string> ıenm = File.ReadLines(file.FullName);
                string tur = file.Name.Substring(1, file.Name.IndexOf("Orm") - 1);

                string name = $"Orm{tur}Dal";
                newFiles.Add(path+name+".cs");

                // Console.WriteLine(name);
                
                
                foreach (string line in ıenm)
                {



                    lines += line + "\n";


                }
                int strt = lines.IndexOf("namespace");

                lines = lines.Substring(strt);
                lines = lines.Replace("interface", "class");
                lines = lines.Replace("DataAccess.Abstract", "DataAccess.Concrete.ORM");
               
                string degistir = "class I"+tur+"Orm" + " : IEntityRepository<"+tur+">";
              
                
                string each = "class "+name+": EfEntityRepositoryBase<"+tur+", "+name+">";
                
                lines = lines.Replace(degistir, each);

                lines = needs + lines;
                each = "";



                listem.Add(lines);
               
            }

            FileStream fs;
            StreamWriter sw;
            for (int i = 0; i < newFiles.Count; i++)
            {
                fs = new FileStream(newFiles[i], FileMode.OpenOrCreate, FileAccess.Write);
                sw = new StreamWriter(fs);
                sw.WriteLine(listem[i]);
                sw.Flush();
                sw.Close();
                fs.Close();
            }

          

        }

    }
}
