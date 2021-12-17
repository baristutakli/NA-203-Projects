using Core.Abstract;
using Core.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    [Table(PrimaryColumn = "ID", TableName = "CorporateCustomers", IdentityColumn = "ID")]
    public class CorporateCustomer:IEntity
    {
        public int ID { get; set; }
        public string CompanyName { get; set; }
        public int Contact { get; set; }
    }
}
