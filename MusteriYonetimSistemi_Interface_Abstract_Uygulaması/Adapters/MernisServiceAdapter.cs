using MusteriYonetimSistemi_Interface_Abstract_Uygulaması.Abstract;
using MusteriYonetimSistemi_Interface_Abstract_Uygulaması.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusteriYonetimSistemi_Interface_Abstract_Uygulaması.Adapters {
    class MernisServiceAdapter : ICustomerCheckService {
        public bool CheckIfRealPerson(Customer customer)
        {
            //MernisServiceReference
            return true;
        }
    }
}
