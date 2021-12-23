using Core.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    [Table(PrimaryColumn = "ID", TableName = "Reviews", IdentityColumn = "ID")]
    public class Review
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public float Rating { get; set; }
        public string Description { get; set; }
    }
}


