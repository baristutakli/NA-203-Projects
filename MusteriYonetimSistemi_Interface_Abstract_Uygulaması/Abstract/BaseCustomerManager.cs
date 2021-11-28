using MusteriYonetimSistemi_Interface_Abstract_Uygulaması.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusteriYonetimSistemi_Interface_Abstract_Uygulaması.Abstract {
    public abstract class BaseCustomerManager : ICustomerService {
        public virtual void Save(Customer customer)
        {

            Console.WriteLine("Save to db. "+customer.FirstName);
        }
    }
}
