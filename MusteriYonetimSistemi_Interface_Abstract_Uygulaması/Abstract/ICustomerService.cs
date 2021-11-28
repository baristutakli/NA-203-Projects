using MusteriYonetimSistemi_Interface_Abstract_Uygulaması.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusteriYonetimSistemi_Interface_Abstract_Uygulaması.Abstract {
    public interface ICustomerService{
        public void Save(Customer customer);
    }
}
