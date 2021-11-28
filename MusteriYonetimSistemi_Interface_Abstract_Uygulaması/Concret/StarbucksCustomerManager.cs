using MusteriYonetimSistemi_Interface_Abstract_Uygulaması.Abstract;
using MusteriYonetimSistemi_Interface_Abstract_Uygulaması.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusteriYonetimSistemi_Interface_Abstract_Uygulaması.Concret {
    public class StarbucksCustomerManager : BaseCustomerManager {
        private ICustomerCheckService _customerCheckService;

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }



        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else { throw new Exception("Not a valid person!"); }
            
            
         
        }
    }
}
