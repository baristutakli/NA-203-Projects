
using Core.Concrete;
using Entities.Abstract;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entities.Concrete
{
   [Table(PrimaryColumn = "ShipperID", TableName = "Shippers", IdendityColumn = "ShipperID")]
    public class Shipper:IEntity
    {
        public  string CompanyName { get; set; }
        public  string Phone { get; set; }
        public int ShipperID { get; set; }
    }
}
