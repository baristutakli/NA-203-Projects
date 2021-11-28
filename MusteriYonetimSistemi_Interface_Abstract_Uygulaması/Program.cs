using MusteriYonetimSistemi_Interface_Abstract_Uygulaması.Abstract;
using MusteriYonetimSistemi_Interface_Abstract_Uygulaması.Concret;
using System;

namespace MusteriYonetimSistemi_Interface_Abstract_Uygulaması {
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ICustomerCheckService customerCheckService = new CustomerCheckManager();
            BaseCustomerManager customerManager = new StarbucksCustomerManager(customerCheckService);
            customerManager.Save(new Entities.Customer { DateOfBirth=new DateTime(1997,3,4),FirstName="Barış",LastName="Tutakli",NationalityId="123456789"});

            BaseCustomerManager customerManager2 = new NeroCustomerManager();
            customerManager2.Save(new Entities.Customer { DateOfBirth = new DateTime(1997, 3, 4), FirstName = "Barış", LastName = "Tutakli", NationalityId = "123456789" });
        }
    }
}
