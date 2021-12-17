using Core.Abstract;
using Core.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    [Table(PrimaryColumn = "ID", TableName = "Shippings", IdentityColumn = "ID")]
    public class Shipping:IEntity
    {
        public int ID { get; set; }
        public DateTime ShippedDate { get; set; }
        public string ShippingCompany { get; set; }
        public int AdressID { get; set; }
    }
}
