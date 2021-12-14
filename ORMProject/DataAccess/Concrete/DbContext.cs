﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DataAccess.Concrete
{
    class DbContext
    {

        private  SqlConnection _connection;

        public  SqlConnection Connection
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

    }
}
