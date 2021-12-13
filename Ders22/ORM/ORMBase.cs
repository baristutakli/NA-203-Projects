using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace ORM
{
    public class ORMBase<ET> : IORM<ET> where ET : class, new()
    {
        public bool Delete(ET entity)
        {
            throw new NotImplementedException();
        }

        public bool Insert(ET entity)
        {
            throw new NotImplementedException();
        }

        public List<ET> Select()
        {
            Type type = typeof(ET);
            string query = "SELECT * FROM ";
            
            var attributes = type.GetCustomAttributes(typeof(Table), false);
            // null değilse ve herhangi bir data varsa
            if (attributes != null && attributes.Any())
            {
                Table tbl = (Table)attributes[0];// 0 dediğimizde TableName'i almış olduk
                query += tbl.TableName+ ";";
            }
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.CommandText = query;
            // Connection static Tools sınıfından geldi.
            adp.SelectCommand.Connection = Tools.Connection;

            DataTable dt = new DataTable();
            adp.Fill(dt);// gelen veriyi dt ye doldurduk
            return dt.ToList<ET>(); 
            // Burada Tools sınıda tanımlayıp DataTable'a bind 
            // ettiğimiz metodu DataTable nesnesi aracılığı ile kullandık.
            

        }

        public bool Update(ET entity)
        {
            throw new NotImplementedException();
        }
    }
}
