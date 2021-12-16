using Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Product:IEntity
    {
        public int ID { get; set; }
        public int ProductDetailsID { get; set; }
        public int  SupplierID { get; set; }
        public int CategoryID { get; set; }
        public string ProductName { get; set; }
    }
}
