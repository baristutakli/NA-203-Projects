using Core.Abstract;
using Core.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    [Table(PrimaryColumn = "ID", TableName = "Customers", IdentityColumn = "ID")]
    public class Customer:IEntity
    {
        public int ID { get; set; }
        public int AdressID { get; set; }
        public int TelID { get; set; }
    }
}
