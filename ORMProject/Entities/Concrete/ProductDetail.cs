using Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class ProductDetail:IEntity
    {
        public int ID { get; set; }
        public int PictureID { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitInStock { get; set; }
        public short UnitOnOrder { get; set; }

    }
}
