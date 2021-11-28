using MusteriYonetimSistemi_Interface_Abstract_Uygulaması.Abstract;
using MusteriYonetimSistemi_Interface_Abstract_Uygulaması.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusteriYonetimSistemi_Interface_Abstract_Uygulaması.Concret {
    public class CustomerCheckManager : ICustomerCheckService {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
