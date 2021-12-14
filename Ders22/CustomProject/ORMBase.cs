using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace ORM
{
    public class ORMBase<ET, OT> : IORM<ET> where ET : class, new()
        where OT : class, new()
    {
        private static OT _current;

        public static OT Current { get { if (_current == null) { _current = new OT(); } return _current; } }

        public Type ETTtype
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
                var attributes = ETTtype.GetCustomAttributes(typeof(Table), false);
                if (attributes != null && attributes.Any())
                {
                    Table tbl = (Table)attributes[0];
                    return tbl;
                }
                return null;
            }
        }

        public bool Delete(ET entity)
        {
            string query = $"UPDATE {TableAtt.TableName} WHERE {TableAtt.PrimaryColumn} ";
            PropertyInfo[] properties = ETTtype.GetProperties();
            foreach (var pi in properties)
            {
                if (pi.Name == TableAtt.IdentityColumn)
                {
                    if (pi.PropertyType.Name.Contains("String"))
                    {
                        query += $"{pi.GetValue(entity)}";
                    }
                    else
                    {
                        query += $" WHERE {TableAtt.PrimaryColumn}={pi.GetValue(entity)}";
                    }


                }

            }
            return true;
        }

        public bool Insert(ET entity)
        {
            string command = "INSERT INTO ";
            string table = TableAtt.TableName;
            PropertyInfo[] properties = ETTtype.GetProperties();


            string props = "";
            string values = "";

            foreach (var pi in properties)
            {
                if (pi.Name != TableAtt.IdentityColumn)
                {
                    props += pi.Name + " ";

                    values += string.Format("'{0}'", pi.GetValue(entity)) + " ";
                }

            }


            props = props.Remove(props.Length - 1, 1);
            // Sondaki fazla virgülü sildik
            values = values.Remove(values.Length - 1, 1);
            props = props.Replace(" ", ",");
            values = values.Replace(" ", ",");
            Console.WriteLine(props);
            Console.WriteLine(values);
            string query = $"{command} {table} ({props}) VALUES ({values})";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.Connection = Tools.Connection;
            Tools.Connection.Open();
            int affedtedRows = cmd.ExecuteNonQuery();
            Tools.Connection.Close();
            if (affedtedRows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }


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
                query += tbl.TableName + ";";
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

        public ET Select(int etID)
        {

            string query = @"SELECT TOP(1) * FROM {0} WHERE {1}={2}";

            var attributes = ETTtype.GetCustomAttributes(typeof(Table), false);

            if (attributes != null && attributes.Any())
            {
                Table tbl = (Table)attributes[0];// 0 dediğimizde TableName'i almış olduk
                query = string.Format(query, tbl.TableName, tbl.PrimaryColumn, etID);
            }

            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.CommandText = query;
            // Connection static Tools sınıfından geldi.
            adp.SelectCommand.Connection = Tools.Connection;

            DataTable dt = new DataTable();


            adp.Fill(dt);

            return dt.TOET<ET>();




            // Burada Tools sınıda tanımlayıp DataTable'a bind 
            // ettiğimiz metodu DataTable nesnesi aracılığı ile kullandık.

        }

        public bool Update(ET entity)
        {

            string query = $"UPDATE {TableAtt.TableName} SET ";
            PropertyInfo[] properties = ETTtype.GetProperties();


            string sets = "";


            foreach (var pi in properties)
            {
                if (pi.Name != TableAtt.IdentityColumn)
                {
                    if (pi.PropertyType.Name.Contains("String"))
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
            // Sondaki fazla virgülü sildik


            query += sets;
            foreach (PropertyInfo pi in properties)
            {
                if(pi.Name == TableAtt.PrimaryColumn)
                    query += $" WHERE {TableAtt.PrimaryColumn}={pi.GetValue(entity)};";
            }
            Console.WriteLine(query);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.Connection = Tools.Connection;
            Tools.Connection.Open();
            int affectedRows = cmd.ExecuteNonQuery();

            Tools.Connection.Close();

            if (affectedRows > 0)
                return true;
            else
                return false;


        }

    }
}
