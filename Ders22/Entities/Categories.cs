using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    // Bu şekilde veri tabanındaki tablo karşılığını ve tablodaki primary key sutununu belirttik.
    [Table(PrimaryColumn ="CategoryID",TableName ="Categories")]
    public class Categories
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Decription { get; set; }
        public byte[] MyProperty { get; set; }
    }
}
