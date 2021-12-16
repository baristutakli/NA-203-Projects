using Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Shipping:IEntity
    {
        public int ID { get; set; }
        public DateTime ShippedDate { get; set; }
        public string ShippingCompany { get; set; }
        public int AdressID { get; set; }
    }
}
