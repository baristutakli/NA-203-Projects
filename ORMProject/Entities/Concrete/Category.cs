using Core.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    [Table(PrimaryColumn = "ID", TableName = "Categories", IdentityColumn = "ID")]
    public class Category
    {
        
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
    }
}
