using Core.Abstract;
using Core.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    [Table(PrimaryColumn = "ID", TableName = "ContactPersons", IdentityColumn = "ID")]
    public class ContactPerson:IEntity
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactTitle { get; set; }
    }
}
