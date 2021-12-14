using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
namespace Entities
{
    [Table(PrimaryColumn = "ShipperID", TableName = "Shippers",IdentityColumn ="ShipperID")]
    public class Shippers
    {
        public int ShipperId { get; set; }
        public string CompanyName { get; set; }
        public string  Phone { get; set; }
    
    }
}
