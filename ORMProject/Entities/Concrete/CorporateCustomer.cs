using Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class CorporateCustomer:IEntity
    {
        public int ID { get; set; }
        public string CompanyName { get; set; },
        public int Contact { get; set; }
    }
}
