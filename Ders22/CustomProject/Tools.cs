using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Reflection;

namespace Common
{
    public static class Tools
    {
        private static SqlConnection _connection;

        public static SqlConnection Connection
        {
            get
            {
                if (_connection == null)
                {
                    _connection = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB;Database=Northwind;Trusted_Connection=true; ");
                }
                return _connection;
            }
            set
            {
                _connection = value;
            }
        }

        /// <summary>
        /// Where ile et class tipinde olma zorunluluğu belirttik
        /// aynı şekilde new() ile bu sınıfın nesne türetilebilir bir sınıf olması zorunluluğunu belirttik
        /// Method binding: this DataTable ile DataTable sınıfına method ekledik.
        /// </summary>
        /// <typeparam name="ET"></typeparam>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static List<ET> ToList<ET>(this DataTable dt) where ET : class, new()
        {
            Type type = typeof(ET);// Gelen tip ne
            List<ET> list = new List<ET>(); // gelen tip nesnelerin olduğu bir liste
            // reflection ile bir sınıfa ait hangi özellikler var öğrenebiliyorum
            PropertyInfo[] properties = type.GetProperties();// sınıfa ait özellikleri bir diziye attık
            foreach (DataRow dr in dt.Rows)
            {
                ET tip = new ET();
                foreach (PropertyInfo pi in properties)
                {
                    object value = dr[pi.Name];// Sınıf özelliğinin adı ile veri tabanındaki tablodan veri çektik
                    // Yani datarow[CategoryName] dediğimizde oradaki veriye ulaşmış olacağız.
                    if (value != null)
                    {
                        pi.SetValue(tip, value);
                    }
                }
                list.Add(tip);
            }
            return list;
        }

        public static ET TOET<ET>(this DataTable dt) where ET : class, new()
        {
            Type type = typeof(ET);// Gelen tip ne
            ET entity = new ET();
            // reflection ile bir sınıfa ait hangi özellikler var öğrenebiliyorum
            PropertyInfo[] properties = type.GetProperties();// sınıfa ait özellikleri bir diziye attık
            foreach (DataRow dr in dt.Rows)
            {
   
                foreach (PropertyInfo pi in properties)
                {
                    object value = dr[pi.Name];// Sınıf özelliğinin adı ile veri tabanındaki tablodan veri çektik
                    // Yani datarow[CategoryName] dediğimizde oradaki veriye ulaşmış olacağız.
                    if (value != null)
                    {
                        pi.SetValue(entity, value);
                    }
                }
               
            }
            return entity;
        }


    }
}
