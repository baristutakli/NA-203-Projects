using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Table:Attribute
    {
        public string TableName { get; set; }
        public string PrimaryColumn { get; set; }
        public string IdendityColumn { get; set; }
    }
}
