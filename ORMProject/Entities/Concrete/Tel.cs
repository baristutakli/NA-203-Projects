using Core.Abstract;
using Core.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    [Table(PrimaryColumn = "ID", TableName = "Tels", IdentityColumn = "ID")]
    public class Tel:IEntity
    {
        public int ID { get; set; }
        public string TelNo { get; set; }
    }
}
