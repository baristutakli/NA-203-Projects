using DataAccess.Abstract;
using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.ORM
{
    public class ORMBase<ET, OT> : IORM<ET>
            where ET : class,  new()
            where OT : class,  new()
    {

        public DbContext Context { get; set; }

        

        private static OT _current;
        public static OT Current
        {
            get
            {
                if (_current == null)
                    _current = new OT();
                return _current;
            }
        }

        public bool Delete(ET entity)
        {
            string query = $"DELETE FROM {TableAtt.TableName} WHERE {TableAtt.PrimaryColumn} = ";

            PropertyInfo[] properties = ETType.GetProperties();
            foreach (var pi in properties)
            {
                if (pi.Name == TableAtt.PrimaryColumn)
                    query += $"{pi.GetValue(entity)};";
            }
            Console.WriteLine(query);

            return ExecuteCommand(query);

        }



        public bool ExecuteCommand(string query)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.Connection = Context.Connection;
            Context.Connection.Open();
            int affectedRows = cmd.ExecuteNonQuery();

            Context.Connection.Close();

            if (affectedRows > 0)
                return true;
            else
                return false;
        }

        public bool Insert(ET entity)
        {
            string command = "INSERT INTO";
            string table = $"{TableAtt.TableName}";
            PropertyInfo[] properties = ETType.GetProperties();
            string props = "";
            string values = "";
            // tablo adından sonraki parantez içine gelecek kolon adları.
            foreach (var pi in properties)
            {
                if (pi.Name != TableAtt.IdendityColumn)
                {
                    props += pi.Name + ",";
                    if (pi.PropertyType.Name.Contains("String"))
                        values += string.Format("'{0}',", pi.GetValue(entity));
                    else
                        values += string.Format("{0},", pi.GetValue(entity));
                }
            }

            props = props.Remove(props.Length - 1, 1);
            values = values.Remove(values.Length - 1, 1);

            string query = $"{command} {table} ({props}) VALUES ({values});";
            //INSERT INTO Shippers(CompanyName, Phone) VALUES('ASD', '123123');
            
            return ExecuteCommand(query);
        }

        public Type ETType
        {
            get
            {
                return typeof(ET);
            }
        }
        public Table TableAtt
        {
            get
            {
                var attributes = ETType.GetCustomAttributes(typeof(Table), false);
                

                if (attributes != null && attributes.Any())
                {
                    Table tbl = (Table)attributes[0];
                    //Console.WriteLine(tbl.TableName);
                    //Console.WriteLine(tbl.PrimaryColumn);
                    return tbl;
                }
                return null;
            }
        }

        public List<ET> Select()
        {
            Type type = typeof(ET);
            string query = "SELECT * FROM ";
            var attributes = type.GetCustomAttributes(typeof(Table), false);
            //Any() => Herhangi bir data var ise True döner.
            // null değil ise ve kayıt var ise.
            if (attributes != null && attributes.Any())
            {
                Table tbl = (Table)attributes[0];
                query += tbl.TableName + ";"; // Table attribute tablosundaki ilk eleman TableName
            }
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.CommandText = query;
            adp.SelectCommand.Connection = Context.Connection; // connection static Context sınıfından geldi.
            DataTable dt = new DataTable();
            adp.Fill(dt); // Gelen veriyi dt ye doldurduk.

            return ToList(dt); // Burada Context sınıfında tanımlayıp DataTable'a bind ettiğimiz yani bağladığımız metodu. DataTable nesnesi aracılığı ile kullandık.

        }
        public ET Select(int etID)
        {
            // ETType;
            string query = @"SELECT TOP(1) * FROM {0} WHERE {1}={2}";
            var attributes = ETType.GetCustomAttributes(typeof(Table), false);

            if (attributes != null && attributes.Any())
            {
                Table tbl = (Table)attributes[0];
                query = string.Format(query, tbl.TableName, tbl.PrimaryColumn, etID);
            }

            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.CommandText = query;
            adp.SelectCommand.Connection = Context.Connection; // connection static Context sınıfından geldi.
            DataTable dt = new DataTable();

            adp.Fill(dt);

            return ToET(dt);

        }
        private  ET ToET(DataTable dt) 
        {
            Type type = typeof(ET);
            ET entity = new ET();
            PropertyInfo[] properties = type.GetProperties();
            foreach (DataRow dr in dt.Rows)
            {
                foreach (PropertyInfo pi in properties)
                {
                    object value = dr[pi.Name]; // Sınıf özelliğinin adı ile veri tabanındaki tablodan veri çektik.
                    // Yani datarow[CategoryID] dediğimizde oradaki veriye ulaşmış olacağız.
                    if (value != null)
                        pi.SetValue(entity, value);
                }
            }
            return entity;
        }

        private  List<ET> ToList( DataTable dt)
        {
            Type type = typeof(ET); // Gelen tip ne? Categories mi, Product mı? Başka birşey mi?  
            List<ET> list = new List<ET>(); // Gelen tip ten nesnelerin olduğu bir liste.
            PropertyInfo[] properties = type.GetProperties(); // Sınıfa ait özellikler bir diziye attık.
            foreach (DataRow dr in dt.Rows)
            {
                ET tip = new ET(); // Categories tip = new Categories();
                foreach (PropertyInfo pi in properties)
                {
                    object value = dr[pi.Name]; // Sınıf özelliğinin adı ile veri tabanındaki tablodan veri çektik.
                    // Yani datarow[CategoryID] dediğimizde oradaki veriye ulaşmış olacağız.
                    if (value != null)
                        pi.SetValue(tip, value);
                }
                list.Add(tip);
            }
            return list;

        }

        public bool Update(ET entity)
        {
            string query = $"UPDATE {TableAtt.TableName} SET ";
            string condition = "";

            PropertyInfo[] properties = ETType.GetProperties();
            string sets = "";
            // tablo adından sonraki parantez içine gelecek kolon adları.
            
            foreach (var pi in properties)
            {
                if (pi.Name != TableAtt.PrimaryColumn)
                {
                    if (pi.PropertyType.Name.Contains("String") || pi.PropertyType.Name.Contains("Char"))
                    {
                        sets += pi.Name + "='" + pi.GetValue(entity) + "',";
                      
                    }
                    else
                    {
                        sets += pi.Name + "=" + pi.GetValue(entity) + ",";
                    
                    }

                }
            }
            sets = sets.Remove(sets.Length - 1, 1);
            query += sets;
            foreach (var pi in properties)
            {
                if (pi.Name == TableAtt.IdendityColumn)
                {
                 condition += $" WHERE {pi.Name}={pi.GetValue(entity)};";
                }
            }

            query += condition;

            
            return ExecuteCommand(query);

        }
    }
}
