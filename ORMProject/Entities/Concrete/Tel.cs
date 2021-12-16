using Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Tel:IEntity
    {
        public int ID { get; set; }
        public string TelNo { get; set; }
    }
}
