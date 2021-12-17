using Core.Abstract;
using Core.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    [Table(PrimaryColumn = "ID", TableName = "Pictures", IdentityColumn = "ID")]
    public class Picture:IEntity
    {
        public int ID { get; set; }
        public string Url { get; set; }

    }
}
